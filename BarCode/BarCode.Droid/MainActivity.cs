
using System;
using Android.App;
using Android.Content.PM;
using Android.Hardware.Bcreader;
using Android.OS;
using Android.Content;

namespace BarCode.Droid
{
    //[Activity(Label = "BarCode", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    [Activity(Label = "北京东软慧聚仓库扫描系统"
	          , Icon = "@drawable/icon"
	          , MainLauncher = true
	          , ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity, Android.Hardware.Bcreader.IBCRListener
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            Zumero.DataGridComponent.Init();
            DevExpress.Mobile.Forms.Init();

            CommCLR.webclient = new WebClient_clr();
            CommCLR.Iscan = new BCRManager_clr(this);
			//加载版本号 android版本
			/*
			Version appVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
			var app_version = string.Format("{0}.{1}.{2}.{3}", appVersion.Major, appVersion.Minor, appVersion.Build, appVersion.Revision);
			*/
			//加载当前设定版本
			Context context = this.ApplicationContext;
			var version = context.PackageManager.GetPackageInfo(context.PackageName, 0).VersionName;
			//end

            LoadApplication(new App());

            mBCRManager = BCRManager.Instance;
            if (!mBCRManager.IsReady)
            {
                mBCRManager.RegisterListener(this);
                mBCRManager.Open(this);
            }
        }


        public BCRManager mBCRManager;
        private BCRTicketInfo[] mBCRTicketInfo = new BCRTicketInfo[] { null, null };
        public Action<string> runcode;
        private Handler mHandler = new Handler();
        void IBCRListener.OnOpened(bool isReady)
        {
            if (isReady)
            {
                mBCRManager.EnableCode(BCRBarCodeValue.CodeTypeAll);
            }
        }

        void IBCRListener.OnScanFinished(int scanType, string elapseTime)
        {
            mBCRTicketInfo = mBCRManager.GetTicketInfo();
            if (runcode != null)
            {
                mHandler.Post(() =>
                {
                    runcode(mBCRTicketInfo[0].TicketValue);
                    //mTextView.SetText(mBCRTicketInfo[0].TicketValue, TextView.BufferType.Normal);

                    // Only a test code for broadcast mode.
                    //var sintent = new Intent("com.neusoft.action.scanner.read");
                    //sintent.PutExtra("scanner_value", mBCRTicketInfo[0].TicketValue);
                    //SendBroadcast(sintent);
                });
            }

        }

        protected void onPause()
        {
            base.OnPause();
            if (mBCRManager.IsReady)
            {
                mBCRManager.Close();
            }

            //// This is for broadcast mode.
            //// If your app wants to work with scanner in broacast mode.
            //// You can add these code to your app.
            //// -S-
            //UnregisterReceiver(receiver);
            //// -E-
        }

        protected void onDestroy()
        {
            base.OnDestroy();
            if (mBCRManager != null)
            {
                mBCRManager.Close();
            }
        }

        public void onBackPressed()
        {
            base.Finish();
        }

    }
}

