namespace Novotec.API.Interfaces;

public interface IApiService
{
    Task<List<T>> FetchData<T>(string endpoint);
}