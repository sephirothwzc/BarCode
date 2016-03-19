using BarCode.Localization;
using BarCode.Models;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using Xamarin.Forms;

namespace BarCode.Pages
{
    public partial class Login : ContentPage
    {
        public string url = string.Empty;// Plugin.Settings.CrossSettings.Current.GetValueOrDefault<string>("pdaservices");

        public Login()
        {
            InitializeComponent();

            //系统设置读取与设置
            this.url = Helpers.Settings.Pdaservices;

            Helpers.Settings.Pdaservices = "111111111111111";

            var sst = Helpers.Settings.Pdaservices;
            //end

            this.SignInButton.GestureRecognizers.Add(
                new TapGestureRecognizer()
                {
                    NumberOfTapsRequired = 1,
                    Command = new Command(SignInButtonTapped)
                });

            this.CancelButton.GestureRecognizers.Add(
                new TapGestureRecognizer()
                {
                    NumberOfTapsRequired = 1,
                    Command = new Command(CancelButtonTapped)
                });

            this.UsernameValueEntry.Focused +=  async delegate
            {
                if (App.haveBcr)
                {
                    CommCLR.Iscan.GetCode((str) =>
                    {
                        this.UsernameValueEntry.Text = str;
                    });
                }
                else
                {
                    var scanner = new ZXing.Mobile.MobileBarcodeScanner();
                    var sesult = await scanner.Scan();
                    if (sesult != null)
                        UsernameValueEntry.Text = sesult.Text;
                }
            };

			/*
            string turl = url + "/GetServiceDateTime";
            string sss = CommCLR.webclient.WebRequest<string>(new Uri(turl), method: "GET");


            string sapurl = url + "/GetVendorTodayBatch";
            IDictionary<string, object> datas = new Dictionary<string, object>();
            datas.Add("plant", "0000100000");
            datas.Add("vendor", new UserDto { Location = "2222" });
            datas.Add("material", "0120010003");

            var strss = CommCLR.webclient.WebRequest<string>(new Uri(sapurl), datas);
			*/


        }

        async void CancelButtonTapped(object obj)
        {
            var result = await DisplayAlert("系统提示", "是否要退出系统！", "确定", "取消");
            if (result)
            {
                FactoryNumentry.Text = "";
                UsernameValueEntry.Text = "";
                PasswordValueEntry.Text = "";
            }

        }
        async void SignInButtonTapped(object obj)
        {
            string facNum = FactoryNumentry.Text;
            string userName = UsernameValueEntry.Text;
            String passWord = PasswordValueEntry.Text;
            Regex rg = new Regex(@"[0-9]{1,}");
            if (String.IsNullOrEmpty(facNum) || !rg.IsMatch(facNum))
            {

                await DisplayAlert("系统提示", "请输入工厂号！", "确定");
                FactoryNumentry.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(userName))
            {
                await DisplayAlert("系统提示", "请输入用户名！", "确定");
                UsernameValueEntry.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(passWord))
            {
                await DisplayAlert("系统提示", "请输入密码！", "确定");

                return;
            }
            string turl = url + "/CheckUser";
            IDictionary<string, object> cudata = new Dictionary<string, object>();

            cudata.Add("plant", facNum);
            cudata.Add("userID", userName);
            cudata.Add("password", passWord);
            UserDto user = CommCLR.webclient.WebRequest<UserDto>(new Uri(turl), cudata);

            if (user != null && !String.IsNullOrEmpty(user.UserID))
            {
                if (Device.OS != TargetPlatform.iOS)
                    App.haveBcr = false;
                else if (Device.OS == TargetPlatform.Android)
                    App.haveBcr = this.Havebcr.IsToggled;
                App.CurrentApp.MainPage = new MDPage();
            }
            else
            {
                await DisplayAlert("系统提示", "用户名、密码错误，请重新输入！", "确定");
            }
        }

    }
}
