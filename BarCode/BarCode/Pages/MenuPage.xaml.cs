using BarCode.Localization;
using BarCode.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace BarCode.Pages
{
    public partial class MenuPage : ContentPage
    {
        List<HomeMenuItem> menuItems;
        MDPage root;
        public MenuPage(MDPage root)
        {
            InitializeComponent();
            this.root = root;

            BindingContext = new BaseViewModel(Navigation)
            {

                Title = TextResources.Splash_Title,
                Subtitle = TextResources.Splash_Title,
                Icon = "icon.png"
            };

            ListViewMenu.ItemsSource = menuItems = new List<HomeMenuItem>
                {
                    new HomeMenuItem { Title = "PO收货", MenuType = MenuType.Receipt, Icon = "products.png" },
                    new HomeMenuItem { Title = "关于", MenuType = MenuType.About, Icon = "about.png" },

                };

            ListViewMenu.SelectedItem = menuItems[0];

            ListViewMenu.ItemSelected += (sender, e) =>
            {
                if (ListViewMenu.SelectedItem == null)
                    return;

                this.root.NavigateAsync(((HomeMenuItem)e.SelectedItem).MenuType);//((HomeMenuItem)e.SelectedItem).MenuType
            };
        }
    }
}
