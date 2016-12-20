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

namespace A01
{
    [Activity(Label = "Ibutton_Activity")]
    public class Ibutton_Activity : Activity
    {

        private static  String TAG = "AclasArmPosDBG";
        private TextView tHdqView;
        private String cardNo;
        private Aclasdriver.AclasHdqApi aclasHdqApi;
    


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ibutton_activity);
          

            aclasHdqApi = new Aclasdriver.AclasHdqApi();
            tHdqView =FindViewById<TextView>(Resource.Id.hdqview);
        }

        protected override void OnResume()
        {
            base.OnResume();
            //Log.d(TAG, "Hdq -------> onResume");
            // threadHdqRead = new MyThread();
            ThreadStart myThreadDelegate = new ThreadStart(ThreadWork.run);
            System.Threading.Thread threadHdqRead = new System.Threading.Thread(myThreadDelegate);
            ThreadWork.stopflag = true;
            if (aclasHdqApi.Open() == 0)
            {
                threadHdqRead.Start();
            }
            else
            {
                //Log.d(TAG, "Can't open the HDQ device");
                Console.WriteLine("No se puede inicializar dispositivo".ToCharArray(), 0, "No se puede inicializar dispositivo".ToCharArray().Length);
                ThreadWork.stopflag = false;

            }
        }

        protected override void OnPause()
        {
            ThreadWork.stopflag = false;
            aclasHdqApi.Close();
            base.OnPause();
        }

        public class ThreadWork
        {
            public static bool stopflag;
            public  String bytesToHexString(byte[] src){   
            StringBuilder stringBuilder = new StringBuilder("");   
            if (src == null || src.Length <= 0) {   
                return null;   
            }   
            for (int i = 0; i < src.Length; i++) {   
                int v = src[i] & 0xFF;
                    String hv = v.ToString("X4");  
                if (hv.Length < 2) {   
                    stringBuilder.Append(0);   
                }
                    stringBuilder.Append(hv);
                }
                return stringBuilder.ToString(); 
            }

            public static bool ArrayCmp(byte[] src, byte[] des)
            {
                for (int i = 0; i < src.Length; i++)
                {
                    if (src[i] != des[i])
                        return false;

                  //  System.out.print(src[i]);

                }
                return true;


            }

            public static bool ArrayZero(byte[] src)
            {
                for (int i = 0; i < src.Length; i++)
                {
                    if (src[i] != 0x00)
                        return false;
                }
                return true;


            }


            public static void run()
            {

                byte[] Data = new byte[8];
                byte[] tmpData;
                mHandler hand = new mHandler();
                Ibutton_Activity obj = new Ibutton_Activity();


                while (stopflag)
                {
                    Message msg = hand.ObtainMessage();
                    tmpData = obj.aclasHdqApi.Read();

                    if (ArrayZero(tmpData))
                    {
                       // Log.d(TAG, "no data");
                        msg.Arg1 = 1;
                       
                    }
                    else
                    {
                        msg.Arg2 = 0;
                    }
                    if (ArrayCmp(tmpData, Data))
                    {
                        //Log.d(TAG, "the same  data continue");
                        try
                        {
                            Thread.Sleep(500);
                        }
                        catch (ThreadInterruptedException e)
                        {
                            // TODO Auto-generated catch block
                            //e.printStackTrace();
                            Console.WriteLine(e.ToString().ToCharArray());
                        }
                        continue;
                    }
                    else
                    {
                        System.Array.Copy(tmpData, 0, Data, 0, 8);
                        obj.cardNo = ByteArrayToString(Data);

                    }
                    hand.SendMessage(msg);

                   // Log.d(TAG, "Hdq -------> Thread");
                    try
                    {
                      //  sleep(500); //200ms
                        Thread.Sleep(500);
                    }
                    catch (ThreadInterruptedException e)
                    {
                        // TODO Auto-generated catch block
                        // e.printStackTrace();
                        Console.WriteLine(e.ToString().ToCharArray());
                    }

                    if (!stopflag) break;
                }
            }

            public static string ByteArrayToString(byte[] ba)
            {
                StringBuilder hex = new StringBuilder(ba.Length * 2);
                foreach (byte b in ba)
                    hex.AppendFormat("{0:x2}", b);
                return hex.ToString();
            }

            //protected override SyncRequest 


        }

        class mHandler : Handler
        {
            public override void HandleMessage(Message message)
            {
                



            }

        }
    }

    
}