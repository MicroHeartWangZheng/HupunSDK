using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HupunSDK.Core
{
    public abstract class BaseClient : IBaseClient
    {
        protected static HttpClient httpClient;

        protected BaseConfig Config;

        protected BaseClient()
        {
            httpClient = httpClient ?? HttpClientFactory.Create();
        }

        public virtual async Task<TResponse> ExecuteAsync<TResponse>(IRequest<TResponse> request) where TResponse : BaseResponse, new()
        {
            TResponse result;
            try
            {
                var requestUri = GetRequestUri(request);

                var requestMessage = new HttpRequestMessage(request.GetHttpMethod(), requestUri)
                {
                    Content = GetRequestContent(request)
                };

                var responseMessage = await httpClient.SendAsync(requestMessage).ConfigureAwait(false);
                var responseContent = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
                result = JsonConvert.DeserializeObject<TResponse>(responseContent);
                result.RequestUri = requestUri;
                result.RequestBody = GetRequestBody(request);
                result.StatusCode = responseMessage.StatusCode;
                result.Headers = responseMessage.Headers;
                result.ResponseBody = responseContent;

                return result;
            }
            catch (Exception ex)
            {
                result = new TResponse
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    ResponseBody = ex.Message
                };
                return result;
            }
        }

        /// <summary>
        /// 执行请求命令.
        /// </summary>
        /// <typeparam name="TResponse">请求类型对应的 响应类型</typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public virtual TResponse Execute<TResponse>(IRequest<TResponse> request) where TResponse : BaseResponse, new()
        {
            TResponse result = null;
            try
            {
                var requestUri = GetRequestUri(request); //根据实例对象 获取api路径 
                var requestMessage = new HttpRequestMessage(request.GetHttpMethod(), requestUri)
                {
                    Content = GetRequestContent(request) //生成请求对象
                };

                var requestBody = string.Empty;
                if (requestMessage.Content != null)
                {
                    requestBody = requestMessage.Content.ReadAsStringAsync().Result;
                }
                var responseMessage = httpClient.SendAsync(requestMessage).Result;    //发送请求 获取响应报文
                var responseContent = responseMessage.Content.ReadAsStringAsync().Result; //获取响应报文的正文
                result = JsonConvert.DeserializeObject<TResponse>(responseContent);       //将响应报文的正文 序列化为response对象

                result.RequestUri = requestUri;
                result.RequestBody = requestBody;
                result.StatusCode = responseMessage.StatusCode;
                result.Headers = responseMessage.Headers;
                result.ResponseBody = responseContent;

                return result;
            }
            catch (Exception ex)
            {
                result = new TResponse
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    ResponseBody = ex.Message
                };

                return result;
            }
        }

        /// <summary>
        /// 获取请求地址
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public abstract string GetRequestUri(IRequest request);

        /// <summary>
        /// 获取请求发送数据
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public abstract string GetRequestBody(IRequest request);

        /// <summary>
        /// 获取请求发送的HttpContent.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public virtual HttpContent GetRequestContent(IRequest request)
        {
            HttpContent result;
            var body = GetRequestBody(request);

            if (string.IsNullOrWhiteSpace(body))
                return null;

            result = (string.IsNullOrWhiteSpace(MediaType) || request.GetHttpMethod() == HttpMethod.Get)
                ? new StringContent(body)
                : new StringContent(body, Encoding.UTF8, MediaType);
            return result;
        }

        /// <summary>
        /// 获取数据提交的MediaType
        /// </summary>
        public virtual string MediaType => "";

    }
}
