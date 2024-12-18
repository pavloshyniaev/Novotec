namespace Novotec.API.Interfaces;

public interface IApiService
{
    Task<T?> FetchData<T>(string endpoint);
}