namespace Yandex.Interfaces
{
    public interface IYandexContext
    {
        Task<string> SendRequestAsync(string yandexApiUrl);
    }
}