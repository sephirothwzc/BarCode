using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mobile.DataGrid.Theme;

using Xamarin.Forms;

namespace BarCode.Pages
{
    public partial class JDdatagrid : ContentPage
    {
        public JDdatagrid()
        {
            InitializeComponent();
            ThemeManager.ThemeName = Themes.Light;
            ThemeManager.Theme.HeaderCustomizer.BackgroundColor = Color.FromRgb(187, 228, 208);
            DevExpress.Mobile.DataGrid.ThemeFontAttributes myFont = new DevExpress.Mobile.DataGrid.ThemeFontAttributes("Verdana",
                                       DevExpress.Mobile.DataGrid.ThemeFontAttributes.FontSizeFromNamedSize(NamedSize.Large),
                                       FontAttributes.None, Color.White);
            ThemeManager.Theme.HeaderCustomizer.Font = myFont;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.grid.ItemsSource = new System.Collections.ObjectModel.ObservableCollection<JDProduct>
            {
                new JDProduct {
                    Name="张三",
                    UnitPrice=20,
                    Date = DateTime.Now,
                    Shipped = true
                },
                new JDProduct {
                    Name="张三2",
                    UnitPrice=50,
                    Date = DateTime.Now,
                    Shipped = false
                },
                new JDProduct {
                    Name="张三3",
                    UnitPrice=40,
                    Date = DateTime.Now,
                    Shipped = true
                },
            };

        }
    }

    public class JDProduct
    {
        public string Name { get; set; }
        public int UnitPrice { get; set; }

        public DateTime Date { get; set; }

        public bool Shipped { get; set; }
    }
}
