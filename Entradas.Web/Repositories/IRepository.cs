namespace Entradas.Web.Repositories
{
    public interface IRepository
    {
        Task<HttpResponseWrapper<T>> Get<T>(string url);

        Task<HttpResponseWrapper<object>> Put<T>(string url, T model);

        Task<HttpResponseWrapper<TResponse>> Put<T, TResponse>(string url, T model);

    }

}
