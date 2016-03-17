using BarCode.Localization;
using BarCode.Pages;
using BarCode.Pages.About;
using BarCode.Pages.Receipt;
using BarCode.ViewModels.Base;
using System.Collections.Generic;
using Xamarin.Forms;

namespace BarCode
{
    /// <summary>
    /// 主界面
    /// </summary>
    public class MDPage : MasterDetailPage
    {
        Dictionary<MenuType, NavigationPage> Pages { get; set; }

        public MDPage()
        {
            Pages = new Dictionary<MenuType, NavigationPage>();
            Master = new MenuPage(this);
            BindingContext = new BaseViewModel(Navigation)
            {
                Title = TextResources.Splash_Title,
                //Icon = "icon.png"
            };
            //setup home page
            NavigateAsync(MenuType.Receipt);
        }

        void SetDetailIfNull(Page page)
        {
            if (Detail == null && page != null)
                Detail = page;
        }

        public async void  NavigateAsync(MenuType id)
        {
            Page newPage;
            if (!Pages.ContainsKey(id))
            {
                switch (id)
                {
                    case MenuType.Receipt:
                        var page = new NeuNavigationPage(new PoAPage
                        {
                            Title = TextResources.Receipt_Title,
                            Icon = new FileImageSource { File = "products.png" }
                        });
                        SetDetailIfNull(page);
                        Pages.Add(id, page);
                        break;
					case MenuType.GridDemo:
						page = new NeuNavigationPage(new GridDemoPage
						{
							Title = TextResources.Receipt_Title,
							Icon = new FileImageSource { File = "products.png" }
						});
						SetDetailIfNull(page);
						Pages.Add(id, page);
					break;
                    case MenuType.About:
                        page = new NeuNavigationPage(new AboutPage
                        {
                            Title = TextResources.About_Title,
                            Icon = new FileImageSource { File = "about.png" }
                        });
                        SetDetailIfNull(page);
                        Pages.Add(id, page);
                        break;

                }
            }

            newPage = Pages[id];
            if (newPage == null)
                return;

            //pop to root for Windows Phone
            if (Detail != null && Device.OS == TargetPlatform.WinPhone)
            {
                await Detail.Navigation.PopToRootAsync();
            }

            Detail = newPage;

            if (Device.Idiom != TargetIdiom.Tablet)
                IsPresented = false;
        }
    }

    public class Task
    {
    }

    /// <summary>
    /// 导航窗体
    /// </summary>
    public class NeuNavigationPage : NavigationPage
    {
        public NeuNavigationPage(Page root)
            : base(root)
        {
            Init();
        }

        public NeuNavigationPage()
        {
            Init();
        }

        void Init()
        {

            BarBackgroundColor = Statics.Palette._001;
            BarTextColor = Color.White;
        }
    }

    /// <summary>
    /// 导航类型
    /// </summary>
    public enum MenuType
    {
        Receipt,
		GridDemo,
        About
    }

    /// <summary>
    /// 导航类
    /// </summary>
    public class HomeMenuItem
    {
        public HomeMenuItem()
        {
            MenuType = MenuType.About;
        }

        public string Icon { get; set; }

        public MenuType MenuType { get; set; }

        public string Title { get; set; }

        public string Details { get; set; }

        public int Id { get; set; }
    }
}
