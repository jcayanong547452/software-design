using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();

        private bool isLoading = false;

        private int currentPage = 1;
        private string lastAuthor = "";

        public Form1()
        {
            InitializeComponent();

            client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0");
        }

        private async void btnFetchBook_Click(object sender, EventArgs e)
        {
            if (isLoading) return;

            string isbn = txtISBN.Text.Trim();

            if (string.IsNullOrWhiteSpace(isbn))
            {
                MessageBox.Show("Please enter ISBN.");
                return;
            }

            isLoading = true;
            btnFetchBook.Enabled = false;

            txtBookDetails.Text = "Loading...";

            try
            {
                string result = await GetBookByISBNAsync(isbn);
                txtBookDetails.Text = result;
            }
            finally
            {
                isLoading = false;
                btnFetchBook.Enabled = true;
            }
        }

        private async Task<string> GetBookByISBNAsync(string isbn)
        {
            try
            {
                await Task.Delay(1200);

                string url = $"https://www.googleapis.com/books/v1/volumes?q=isbn:{isbn}";

                HttpResponseMessage response = await client.GetAsync(url);

                if (response.StatusCode == System.Net.HttpStatusCode.TooManyRequests)
                {
                    return "Too many requests. Please wait a few minutes and try again.";
                }

                if (!response.IsSuccessStatusCode)
                {
                    return $"API Error: {response.StatusCode}";
                }

                string json = await response.Content.ReadAsStringAsync();

                using JsonDocument doc = JsonDocument.Parse(json);
                var root = doc.RootElement;

                if (!root.TryGetProperty("items", out JsonElement items))
                {
                    return "No book found.";
                }

                var book = items[0].GetProperty("volumeInfo");

                string title = book.TryGetProperty("title", out var t) ? t.GetString() : "N/A";

                string authors = book.TryGetProperty("authors", out var a)
                    ? string.Join(", ", a.EnumerateArray())
                    : "Unknown";

                string published = book.TryGetProperty("publishedDate", out var p)
                    ? p.GetString()
                    : "N/A";

                return $"Title: {title}\r\nAuthors: {authors}\r\nPublished: {published}";
            }
            catch (TaskCanceledException)
            {
                return "Request timed out.";
            }
            catch (HttpRequestException ex)
            {
                return "Network error: " + ex.Message;
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        private async void btnSearchAuthor_Click(object sender, EventArgs e)
        {
            string author = txtAuthor.Text.Trim();

            if (string.IsNullOrWhiteSpace(author))
            {
                MessageBox.Show("Enter author name.");
                return;
            }

            lastAuthor = author;
            currentPage = 1;

            await LoadAuthorBooks();
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            await LoadAuthorBooks();
        }

        private async void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                await LoadAuthorBooks();
            }
        }

        private async Task LoadAuthorBooks()
        {
            if (isLoading) return;

            isLoading = true;
            lstBooks.Items.Clear();
            lstBooks.Items.Add("Loading...");

            try
            {
                var books = await GetBooksByAuthorPagedAsync(lastAuthor, currentPage);

                lstBooks.Items.Clear();

                if (books.Count == 0)
                {
                    lstBooks.Items.Add("No books found.");
                    return;
                }

                foreach (var b in books)
                {
                    lstBooks.Items.Add(b);
                }
            }
            catch (Exception ex)
            {
                lstBooks.Items.Clear();
                lstBooks.Items.Add("Error: " + ex.Message);
            }
            finally
            {
                isLoading = false;
            }
        }

        private async Task<List<string>> GetBooksByAuthorPagedAsync(string author, int page)
        {
            try
            {
                await Task.Delay(1200);

                int pageSize = 10;
                int startIndex = (page - 1) * pageSize;

                string url =
                    $"https://www.googleapis.com/books/v1/volumes?q=inauthor:{author}" +
                    $"&startIndex={startIndex}&maxResults={pageSize}";

                HttpResponseMessage response = await client.GetAsync(url);

                if (response.StatusCode == System.Net.HttpStatusCode.TooManyRequests)
                {
                    return new List<string> { "Too many requests. Please wait." };
                }

                if (!response.IsSuccessStatusCode)
                {
                    return new List<string> { $"API Error: {response.StatusCode}" };
                }

                string json = await response.Content.ReadAsStringAsync();

                List<string> books = new List<string>();

                using JsonDocument doc = JsonDocument.Parse(json);
                var root = doc.RootElement;

                if (!root.TryGetProperty("items", out JsonElement items))
                    return books;

                foreach (var item in items.EnumerateArray())
                {
                    var info = item.GetProperty("volumeInfo");

                    string title = info.TryGetProperty("title", out var t)
                        ? t.GetString()
                        : "No Title";

                    books.Add(title);
                }

                return books;
            }
            catch
            {
                return new List<string> { "Error loading books." };
            }
        }
    }
}