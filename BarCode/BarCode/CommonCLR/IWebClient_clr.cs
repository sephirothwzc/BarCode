using System;
using System.Collections.Generic;

namespace BarCode
{
    /// <summary>
    /// web服务接口对象
    /// </summary>
    public interface IWebClient_clr
    {
        T WebRequest<T>(Uri uri, IDictionary<string, object> datas = null, string method = "POST", string charset = "UTF8");

        System.Threading.Tasks.Task<T> WebRequestAsync<T>(Uri uri, IDictionary<string, object> datas = null, string method = "POST", string charset = "UTF8");

        void WebRequestCompleted<T>(Uri uri, IDictionary<string, object> datas = null, string method = "POST", string charset = "UTF8", Action<T> RunT = null);

        string ObjectToJson(object obj);

        T ObjectConvertJson<T>(string jsonstr);
    }
}
