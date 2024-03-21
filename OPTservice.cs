using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class EmailService
{
    public async Task<string> SendEmail(string receiver)
    {
        var client = new HttpClient();

        var requestData = new
        {
            receiver = receiver
        };

        var jsonContent = JsonConvert.SerializeObject(requestData);
        var content = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri("https://auth.pns-ict.tech/v1/email-send"),
            Headers =
            {
                { "User-Agent", "insomnia/8.6.1" },
            },
            Content = content
        };

        var response = await client.SendAsync(request);
        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();
        dynamic jsonResponse = JsonConvert.DeserializeObject(responseBody);

        return jsonResponse.otp.ToString();
    }
}
