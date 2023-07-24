using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.WebRequestMethods;

namespace quotesgeneration
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected async void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Make the API request and update the Label text
                await LoadQuoteAsync();
            }
        }

        private async Task LoadQuoteAsync()
        {
            try
            {
                // Replace "YOUR_API_ENDPOINT" with the actual URL of the quotes API
                string apiEndpoint = "https://api.quotable.io/quotes/random";

                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync(apiEndpoint);

                    if (response.IsSuccessStatusCode)
                    {
                        // Read the response content as a string
                        string responseContent = await response.Content.ReadAsStringAsync();

                        // Use JsonDocument to parse the JSON
                        using (JsonDocument document = JsonDocument.Parse(responseContent))
                        {
                            // Verify that the JSON is an array (it should be based on the previous response)
                            if (document.RootElement.ValueKind == JsonValueKind.Array)
                            {
                                // Get the first item in the array
                                JsonElement quoteElement = document.RootElement.EnumerateArray().FirstOrDefault();

                                // Access the "content" property and set the Label text
                                if (quoteElement.TryGetProperty("content", out JsonElement contentElement))
                                {
                                    Label1.Text = contentElement.GetString();
                                }
                                else
                                {
                                    Label1.Text = "Failed to fetch the quote content.";
                                }
                            }
                            else
                            {
                                Label1.Text = "Invalid JSON response format (expected an array).";
                            }
                        }
                    }
                    else
                    {
                        // Handle error cases
                        Label1.Text = "Failed to fetch the quote.";
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occurred during the API request
                Label1.Text = "An error occurred: " + ex.Message;
            }
        }

        // Define a class to match the structure of the JSON response
       
    }
}