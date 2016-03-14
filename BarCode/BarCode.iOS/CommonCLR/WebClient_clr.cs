using BarCode;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;


namespace BarCode.iOS
{
    /// <summary>
    /// webclient������
    /// </summary>
    public class WebClient_clr : IWebClient_clr
    {
        public WebClient_clr()
        {
            
        }


        public T WebRequest<T>(Uri uri, IDictionary<string, string> datas = null, string method = "POST", string charset = "UTF8")
        {
            string data = string.Empty;
            if (datas != null)
            {
                var namevalues = datas.ToList().Select(d => string.Format(@"{0}:'{1}'", d.Key, d.Value)).ToArray();
                data = "{" + string.Join(",", namevalues) + "}";
            }

            using (WebClient webClient = new WebClient())
            {
                //webClient.Encoding = (Encoding)Enum.Parse(typeof(Encoding), charset);
                webClient.Headers["Method"] = method.ToString();
                webClient.Headers["Content-Type"] = string.Format(@"application/json;charset={0}", charset);
                string dwstring;
                if ("POST".Equals(method))
                    dwstring = webClient.UploadString(uri, method, data);
                else
                    dwstring = webClient.DownloadString(uri);

                return JsonConvert.DeserializeObject<T>(dwstring);
            }
        }

        /// <summary>
        /// �첽���÷��ؽ��
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="uri"></param>
        /// <param name="datas"></param>
        /// <param name="method"></param>
        /// <param name="charset"></param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task<T> WebRequestAsync<T>(Uri uri, IDictionary<string, string> datas = null, string method = "POST", string charset = "UTF8")
        {
            string data = string.Empty;
            if (datas != null)
            {
                var namevalues = datas.ToList().Select(d => string.Format(@"{0}:'{1}'", d.Key, d.Value)).ToArray();
                data = "{" + string.Join(",", namevalues) + "}";
            }
            using (WebClient webClient = new WebClient())
            {
                //webClient.Encoding = (Encoding)Enum.Parse(typeof(Encoding), charset);
                webClient.Headers["Method"] = method.ToString();
                webClient.Headers["Content-Type"] = string.Format(@"application/json;charset={0}", charset);
                string dwstring;
                if ("POST".Equals(method))
                    dwstring = await webClient.UploadStringTaskAsync(uri, method, data);
                else
                    dwstring = await webClient.DownloadStringTaskAsync(uri);

                return JsonConvert.DeserializeObject<T>(dwstring);

            }
        }


        public void WebRequestCompleted<T>(Uri uri, IDictionary<string, string> datas = null, string method = "POST", string charset = "UTF8", Action<T> RunT = null)
        {
            string data = string.Empty;
            if (datas != null)
            {
                var namevalues = datas.ToList().Select(d => string.Format(@"{0}:'{1}'", d.Key, d.Value)).ToArray();
                data = "{" + string.Join(",", namevalues) + "}";
            }
            using (WebClient webClient = new WebClient())
            {
                //webClient.Encoding = (Encoding)Enum.Parse(typeof(Encoding), charset);
                webClient.Headers["Method"] = method.ToString();
                webClient.Headers["Content-Type"] = string.Format(@"application/json;charset={0}", charset);
                if ("POST".Equals(method))
                {
                    webClient.UploadStringCompleted += (sender, e) =>
                    {
                        var dwstring = e.Result;
                        if (RunT != null)
                            RunT(JsonConvert.DeserializeObject<T>(dwstring));
                    };
                    webClient.UploadStringAsync(uri, method, data);
                }
                else
                {
                    webClient.DownloadStringCompleted += (sender, e) =>
                    {
                        var dwstring = e.Result;
                        if (RunT != null)
                            RunT(JsonConvert.DeserializeObject<T>(dwstring));
                    };
                    webClient.DownloadStringAsync(uri);
                }
            }
        }


        #region �ַ����������л�--ObjectConvertJson
        /// <summary>
        /// �ַ����������л�
        /// </summary>
        /// <param name="jsonstr"></param>
        /// <returns></returns>
        public static T ObjectConvertJson<T>(string jsonstr)
        {
            try
            {
                if (string.IsNullOrEmpty(jsonstr) || jsonstr == "{}" || jsonstr == "Token String in state Start would result in an invalid JavaScript object.")
                    return default(T);
                if (!typeof(T).Name.Equals("Object"))//�����ڶ�̬����
                    return JsonConvert.DeserializeObject<T>(jsonstr);

                return default(T);
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
                throw new NotImplementedException(jsonstr + "\r\n+" + ex.Message);
            }
        }
        #endregion

        #region �������л�json-ObjectToJson
        /// <summary>
        /// ObjectToJson �������л� ����json
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public string ObjectToJson(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
        #endregion
    }
}