
using Xamarin.Forms;

namespace BarCode.Pages.Receipt
{
    public class PoReceiptPage : ContentPage
    {
        public PoReceiptPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
            Content.BackgroundColor = Color.White;
        }
    }
}
