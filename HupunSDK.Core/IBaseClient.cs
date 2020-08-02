using System.Threading.Tasks;

namespace HupunSDK.Core
{
    public interface IBaseClient
    {
        Task<TResponse> ExecuteAsync<TResponse>(IRequest<TResponse> request) where TResponse : BaseResponse, new();

        TResponse Execute<TResponse>(IRequest<TResponse> request) where TResponse : BaseResponse, new();
    }
}
