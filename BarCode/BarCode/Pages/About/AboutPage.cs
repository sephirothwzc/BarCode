
using BarCode.Localization;
using Xamarin.Forms;

namespace BarCode.Pages.About
{
    public class AboutPage : ContentPage
    {
        public AboutPage()
        {
			
			var btn = new Button
			{
				Text = TextResources.Add_Title,
			};
			btn.Clicked += (sender, e) => 
			{
				Device.OpenUri(new System.Uri("http://www.baidu.com"));
			};
			Content = new StackLayout
			{
				Children = {
					new Label { Text = TextResources.About_Context },
					btn
                }

            };
            Content.BackgroundColor = Color.White;
        }
    }
}
