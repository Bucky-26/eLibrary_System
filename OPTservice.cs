using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class EmailService
{
    private readonly HttpClient _httpClient;
    private const string ApiBaseUrl = "https://auth.pns-ict.tech/v1"; // Base URL for API

    public EmailService()
    {
        _httpClient = new HttpClient();
        _httpClient.DefaultRequestHeaders.Add("User-Agent", "insomnia/8.6.1");
    }

    public async Task<string> SendEmail(string receiver)
    {
        var requestData = new
        {
            receiver = receiver
        };
        var jsonContent = JsonConvert.SerializeObject(requestData);
        var content = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");

        var requestUri = new Uri($"{ApiBaseUrl}/email-send");
        var response = await _httpClient.PostAsync(requestUri, content);
        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();
        dynamic jsonResponse = JsonConvert.DeserializeObject(responseBody);
        return jsonResponse.otp.ToString();
    }

    public async Task<bool> ValidateOTP(string email, string otp)
    {
        try
        {
            var requestData = new
            {
                email = email,
                otp = otp
            };
            var jsonContent = JsonConvert.SerializeObject(requestData);
            var content = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");

            var requestUri = new Uri($"{ApiBaseUrl}/otp-check");
            var response = await _httpClient.PostAsync(requestUri, content);

            // Check if the response is successful
            if (response.IsSuccessStatusCode)
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                dynamic jsonResponse = JsonConvert.DeserializeObject(responseBody);
                bool isValidOTP = jsonResponse.valid; // Assuming "valid" property contains the validity information
                return isValidOTP;
            }
            else
            {
                // Log the response status and content for debugging
                var errorContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Error: {response.StatusCode} - {errorContent}");
                return false;
            }
        }
        catch (Exception ex)
        {
            // Log any exception that occurs during the request
            Console.WriteLine($"Exception: {ex.Message}");
            return false;
        }
    }

}
