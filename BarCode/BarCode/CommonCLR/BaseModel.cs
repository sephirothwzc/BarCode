using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace BarCode.CommonCLR
{
    public class BaseModel
    {
        public static int GetPropertyValueLenth(object obj,string PropertyName)
        {
            return (obj.GetType().GetRuntimeProperty(PropertyName).GetValue(obj) ?? "").ToString().Length;
        }
    }
}
