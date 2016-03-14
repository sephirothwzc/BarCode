using System.Globalization;

namespace BarCode.Localization
{
    /// <summary>
    /// 定义一个接口暴露用户的首选UICulture 本地资源化对象
    /// </summary>
    public interface ILocalize
    {
        CultureInfo GetCurrentCultureInfo();
    }
}
