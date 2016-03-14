using System;

using Xamarin.Forms;

namespace BarCode.Pages.Receipt
{
    public partial class PoAPage : ContentPage
    {
        public PoAPage()
        {
            InitializeComponent();

            this.dp_outtime.Date = DateTime.Now;

            this.EntPro.Focused += async delegate
             {
                 if (App.haveBcr)
                 {
                     CommCLR.Iscan.GetCode((str) =>
                     {
                         this.EntPro.Text = str;
                     });
                 }
                 else
                 {
                     var scanner = new ZXing.Mobile.MobileBarcodeScanner();
                     var sesult = await scanner.Scan();
                     if (sesult != null)
                         EntPro.Text = sesult.Text;
                 }
             };

            //    this.EntPro.Focused += async delegate
            //    {
            //        if (App.haveBcr)
            //        {
            //            CommCLR.Iscan.GetCode((string str) => 
            //            {
            //                this.EnPro.Text = str;
            //            });
            //        }
            //        else
            //        {
            //            var scanner = new ZXing.Mobile.MobileBarcodeScanner();
            //            var sesult = await scanner.Scan();
            //            if (sesult != null)
            //                EntPro.Text = sesult.Text;
            //        }
            //    };
        }
    }
}
