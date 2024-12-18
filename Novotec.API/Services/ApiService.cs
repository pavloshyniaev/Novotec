using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Novotec.API.Interfaces;

public class ApiService : IApiService
{
    private readonly HttpClient _httpClient;
    private readonly string _baseUrl;

    public ApiService(IConfiguration configuration)
    {
        _httpClient = new HttpClient();
        _baseUrl = configuration.GetValue<string>("Settings:BaseUrl") ?? throw new ArgumentNullException(_baseUrl);
    }

    public async Task<T?> FetchData<T>(string endpoint)
    {
        try
        {
            using var response = await _httpClient.GetAsync(_baseUrl + endpoint);

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();

            var data = JsonSerializer.Deserialize<T>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return data;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            throw;
        }
    }
}