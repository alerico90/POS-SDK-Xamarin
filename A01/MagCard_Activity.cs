using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Threading;
using Java.Lang;
using A01;
using static Android.Resource;

namespace A01
{
    [Activity(Label = "MagCard_Activity")]
    public class MagCard_Activity : Activity
    {


         static string TAG = "AclasArmPosDBG";
         TextView MgText = null;
         Aclasdriver.AclasMagcardApi MgcardAPI = null;
         Button bMagcardE = null;
        

          string[] MagcardNo = new string[3];
         string MAG_OPEN_ERR_STRING;

        

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.magcard_activity);
            // Create your application here

            MgText = FindViewById<TextView>(Resource.Id.MagcardText);
            bMagcardE = FindViewById<Button>(Resource.Id.Btexit);

            bMagcardE.Click += (sender, e) =>
            {
                Finish();
            };

            MgcardAPI = new Aclasdriver.AclasMagcardApi();

            MAG_OPEN_ERR_STRING = "Open Magcard Reader Error";

        }

        protected override void OnResume()
        {
            //ThreadMagcardRead = new ThreadWork();
            ThreadStart myThreadDelegate = new ThreadStart(ThreadWork.DoWork);
            System.Threading.Thread ThreadMagcardRead = new System.Threading.Thread(myThreadDelegate);
            ThreadWork.runflag = true;
            if (MgcardAPI.Open() == 0)
            {
                ThreadMagcardRead.Start();
            }
            else
            {
                MgText.SetText(MAG_OPEN_ERR_STRING.ToCharArray(),0, MAG_OPEN_ERR_STRING.ToCharArray().Length);
            }
            base.OnResume();
        }
        protected override void OnPause()
        {
            ThreadStart myThreadDelegate = new ThreadStart(ThreadWork.DoWork);
            System.Threading.Thread ThreadMagcardRead = new System.Threading.Thread(myThreadDelegate);
            ThreadWork.runflag = false;
            MgcardAPI.Close();
          //  Log.d(TAG, "Magcard ------> OnPause LEAVE");
            base.OnPause();
        }





        public class ThreadWork
        {
            public static bool runflag;
            static mHandler hand = new mHandler();

            public static void DoWork()
            {
                int i;
                 MagCard_Activity obj = new MagCard_Activity();

                while (runflag)
                {
                    Message msg = new Message();    
                    msg = hand.ObtainMessage();
                  //  Message msg = Handler...obtainMessage();
                    if (!runflag) break;
                   // Log.d(TAG, "Magcard ------> Thread");

                    if ((i = obj.MgcardAPI.Read(obj.MagcardNo)) > 0)
                    {
                        // Log.d(TAG, "Send The Message to the ReadHandler");
                        hand.SendMessage(msg);
                        
                    }
                    else
                    {
                        //Log.d(TAG, "Read error =========");
                       // System.out.println(i);
                       // Log.d(TAG, "Read error =========");
                    }
                }
            }

            
        }

        class mHandler : Handler
        {
            public override void HandleMessage(Message message)
            {
                MagCard_Activity obj = new MagCard_Activity();
                string aux;
                obj.MgcardAPI.Beep();
                aux = "track1:" + obj.MagcardNo[0] + "\n" + "track2:" + obj.MagcardNo[1] + "\n" + "track3:" + obj.MagcardNo[2];
                obj.MgText.SetText(aux.ToCharArray(),0,aux.ToCharArray().Length);
                    


            }
            
        }

    }


   

}