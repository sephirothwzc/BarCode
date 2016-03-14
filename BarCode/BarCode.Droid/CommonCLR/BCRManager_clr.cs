using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Hardware.Bcreader;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Util;
using BarCode.Droid;

namespace BarCode
{
    public class BCRManager_clr :IScanning
    {
        public MainActivity bcrm;
        public BCRManager_clr(MainActivity main)
        {
            //this.bcrm = new BCRM(main);
            this.bcrm = main;
        }
        void IScanning.GetCode(Action<string> returncode)
        {
            bcrm.runcode = returncode;
            bcrm.mBCRManager.StartScan(BCRManager.ScanTypeSingle, BCRManager.ScanModeOneshot);
        }
    }

    public class BCRM : Android.Hardware.Bcreader.IBCRListener
    {

        public BCRM(MainActivity main)
        {
            mBCRManager = BCRManager.Instance;
            if (!mBCRManager.IsReady)
            {
                mBCRManager.RegisterListener(this);
                mBCRManager.Open(main);
            }
        }

        void IDisposable.Dispose()
        {
            //throw new NotImplementedException();
        }

        #region IBCRListener

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
                runcode(mBCRTicketInfo[0].TicketValue);
        }

        public BCRManager mBCRManager;
        private BCRTicketInfo[] mBCRTicketInfo = new BCRTicketInfo[] { null, null };
        public Action<string> runcode;

        IntPtr IJavaObject.Handle
        {
            get
            {
                throw new NotImplementedException();
            }
        }


        protected void onPause()
        {
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
            if (mBCRManager != null)
            {
                mBCRManager.Close();
            }
        }

        public void onBackPressed()
        {

        }
        #endregion
    }
}