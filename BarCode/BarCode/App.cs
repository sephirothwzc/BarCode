using BarCode.Localization;
using BarCode.Pages;

using Xamarin.Forms;

namespace BarCode
{
    public class App : Application
    {
        /// <summary>
        /// 公共封装主对象
        /// </summary>
        private static Application appli;
        public static Application CurrentApp
        {
            get { return appli; }
        }

        /// <summary>
        /// 是否使用扫描头
        /// </summary>
        public static bool haveBcr = true;
        
        /// <summary>
        /// 主程序加载
        /// </summary>
        public App()
        {
            // The root page of your application
            //MainPage = new ContentPage
            //{
            //    Content = new StackLayout
            //    {
            //        VerticalOptions = LayoutOptions.Center,
            //        Children = {
            //            new Label {
            //                XAlign = TextAlignment.Center,
            //                Text = "Welcome to Xamarin Forms!"
            //            }
            //        }
            //    }
            //};

            if (Device.OS != TargetPlatform.WinPhone)
            {
                TextResources.Culture = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            }
            //MainPage = new Login();
            MainPage = new JDdatagrid();
            appli = this;

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
