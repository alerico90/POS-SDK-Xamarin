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
using Java.IO;
using Java.Lang;

namespace A01
{
    [Activity(Label = "SerialPort_Activity")]
    public class SerialPort_Activity : Activity
    {

        private Aclasdriver.SerialPort mserial = null;
        public static System.IO.Stream mOutputStream;
        private static System.IO.Stream mInputStream;
        private int fd;
        public static TextView terial, tread;
        public static string STRING_SERIALERR, STRING_READ;
        public static  string tag = "AclasArmPosDBG";
        public static bool runflag;

       
            public abstract class ISERIALMSG : A01.SerialPort_Activity.SERIALMSG
            {
                public static int msg_read;

                public int MSG_READ
                {
                    get { return msg_read; }
                    set { msg_read = 1; }
                }


            }

            protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.serial_port_activity);
            // Create your application here

            terial = FindViewById<TextView>(Resource.Id.textView_serial);
            tread = FindViewById<TextView>(Resource.Id.textView_read); 
            STRING_SERIALERR = "Error al abrir puerto";
            STRING_READ ="Buffer de lectura: ";
            tread.SetText(STRING_READ.ToCharArray(),0, STRING_READ.ToCharArray().Length);
        }

        protected override void OnPause()
        {
            base.OnPause();
            if (mserial != null)
                mserial.Close();
            SerialPort_Activity.runflag = false;
        }

        protected override void OnResume()
        {
            base.OnResume();

            try
            {
                mserial = new Aclasdriver.SerialPort(new File("/dev/ttyS3"), 9600, 0);
                mOutputStream = mserial.MFileOutputStream;
                mInputStream = mserial.MFileInputStream;
                
            }
            catch (SecurityException e)
            {
                // TODO Auto-generated catch block
                //e.printStackTrace();
            }
            catch (IOException e)
            {
                // TODO Auto-generated catch block
                //e.printStackTrace();
            }
        }

        public override bool DispatchKeyEvent(KeyEvent e)
        {
           
            return base.DispatchKeyEvent(e);
        }


        class SerialWriteThread : Thread
        {

        public void run()
        {
            byte[] rdbuf = new byte[200];
            while (SerialPort_Activity.runflag == true)
            {

                byte[] wrbuf = { (byte)'S', (byte)'e', (byte)'r', (byte)'i', (byte)'a', (byte)'l', (byte)' ', (byte)'T', (byte)'e', (byte)'s', (byte)'t', (byte)'\n' };
               // Log.d(tag, "serial output" + mOutputStream);
                if (mOutputStream != null)
                {
                    try
                    {
                        SerialPort_Activity.mOutputStream.Write(wrbuf,0,wrbuf.Length);
                    }
                    catch (IOException e)
                    {
                        // TODO Auto-generated catch block
                       // e.printStackTrace();
                    }
                }

                try
                {
                    Sleep(1000);
                }
                catch (InterruptedException e)
                {
                    // TODO Auto-generated catch block
                  //  e.printStackTrace();
                }

               // Log.d(tag, "serial read thread\n");
                if (mInputStream != null)
                {
                    gui_show obje = new gui_show();

                    try
                    {
                        int size = mInputStream.Read(rdbuf,0,rdbuf.Length);
                      //  Log.d(tag, "read" + size + "bytes");
                        if (size > 0)
                        {
                            byte[] sendbuf = new byte[size];
                            char[] aux = new char[size];
                            for (int i = 0; i < size; i++) { sendbuf[i] = rdbuf[i]; }
                            Message msg_read = obje.ObtainMessage();
                            msg_read.Arg1 = ISERIALMSG.msg_read;
                            aux = Encoding.ASCII.GetChars(sendbuf);
                            msg_read.Obj = new string(new string(aux, 0, aux.Length).ToCharArray());
                            obje.SendMessage(msg_read);
                        }
                    }
                    catch (IOException e)
                    {
                        // TODO Auto-generated catch block
                       // e.printStackTrace();
                    }
                }

            }

        }

     
      
    }

        public interface SERIALMSG
        {

            int MSG_READ { get; set; }
            }

        
            
            
        }


        class gui_show : Handler
        {

            public abstract class ISERIALMSG : A01.SerialPort_Activity.SERIALMSG
            {
               public  static int msg_read;

                public int MSG_READ
                {
                    get { return msg_read; }
                    set { msg_read = 1; }
                }

            
            }

            public override void HandleMessage(Message msg)
                {
                    base.HandleMessage(msg);

                ISERIALMSG.msg_read = 1;
                    switch (msg.Arg1)
                    {
                        case 1:
                           SerialPort_Activity. tread.SetText((SerialPort_Activity.STRING_READ + ": " + (string)msg.Obj).ToCharArray(),0, (SerialPort_Activity.STRING_READ + ": " + (string)msg.Obj).ToCharArray().Length);
                            break;
                    }
                }

        

            }

        }









