
using BarCode.Localization;
using Xamarin.Forms;

namespace BarCode.Pages.About
{
    public class AboutPage : ContentPage
    {
        public AboutPage()
        {
            Content = new StackLayout
            {
                Children = {
					new Label { Text = TextResources.About_Context }
                }
            };
            Content.BackgroundColor = Color.White;
        }
    }
}
