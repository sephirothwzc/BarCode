using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarCode
{
    /// <summary>
    /// 扫描接口
    /// </summary>
    public interface IScanning
    {
        /// <summary>
        /// 获取编码
        /// </summary>
        /// <returns></returns>
        void GetCode(Action<string> returncode); 
    }
}
