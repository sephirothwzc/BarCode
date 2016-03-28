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

            this.grid.SelectionChanged += (send,e) => 
            {
                System.Collections.ObjectModel.ObservableCollection<JDProduct> jd =(System.Collections.ObjectModel.ObservableCollection<JDProduct>)this.grid.ItemsSource;

                DisplayAlert("Alert from ", "OK" + jd[e.RowHandle].Name, "OK");
            };
        }

        void nameClient(object sender, EventArgs args)
        {
            var jdp = ((Button)sender).BindingContext as JDProduct;
            DisplayAlert("Alert from ", "OK"+jdp.Shipped, "OK");
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

        void OnSwipeButtonShowing(object sender, DevExpress.Mobile.DataGrid.SwipeButtonShowingEventArgs e)
        {
            if ((!(Boolean)grid.GetCellValue(e.RowHandle, "Shipped"))
                && (e.ButtonInfo.ButtonName == "RightButton"))
            {
                e.IsVisible = false;
            }
        }

        void OnSwipeButtonClick(object sender, DevExpress.Mobile.DataGrid.SwipeButtonEventArgs e)
        {
            if (e.ButtonInfo.ButtonName == "LeftButton")
            {
                DateTime orderDate = (DateTime)grid.GetCellValue(e.RowHandle, "Date");
                string orderDateDay = orderDate.ToString("dddd");
                DisplayAlert("Alert from " + e.ButtonInfo.ButtonName, "Day: " + orderDateDay, "OK");
            }
            if (e.ButtonInfo.ButtonName == "RightButton")
            {
                grid.DeleteRow(e.RowHandle);
            }
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
