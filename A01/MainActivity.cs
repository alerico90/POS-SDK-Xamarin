using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace A01
{
    [Activity(Label = "A01", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);


            var printer = FindViewById<ImageButton>(Resource.Id.print);
            var display = FindViewById<ImageButton>(Resource.Id.lcd);
            var mag_card = FindViewById<ImageButton>(Resource.Id.mag_card);
            var ibutton = FindViewById<ImageButton>(Resource.Id.ibutton);
            var serial_port = FindViewById<ImageButton>(Resource.Id.serial_port);
            var drawer = FindViewById<ImageButton>(Resource.Id.drawer);
            

            printer.Click += (sender, e)=>{
     
                Intent intent = new Intent(this.ApplicationContext, typeof(Print_Activity));
                StartActivity(intent);
            };

          
            display.Click += (sender, e) => {
                Intent intent = new Intent(this.ApplicationContext, typeof(Display_Activity));
                StartActivity(intent);
            };

            mag_card.Click += (sender, e) => {
                Intent intent = new Intent(this.ApplicationContext, typeof(MagCard_Activity));
                StartActivity(intent);
            };

            ibutton.Click += (sender, e) => {
                Intent intent = new Intent(this.ApplicationContext, typeof(Ibutton_Activity));
                StartActivity(intent);
            };

            serial_port.Click += (sender, e) => {
                Intent intent = new Intent(this.ApplicationContext, typeof(SerialPort_Activity));
                StartActivity(intent);
            };

            drawer.Click += (sender, e) => {
                Intent intent = new Intent(this.ApplicationContext, typeof(Drawer_Activity));
                StartActivity(intent);
            };

            //button.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            byte[] testchar = { 0x1b, 0x21, 0x00, (byte)'P', (byte)'R', (byte)'U', (byte)'E', (byte)'B', (byte)'A' };
            byte[] tmpfeed = { 0xd, 0xa };
            Aclasdriver.Printer obj_printer = new Aclasdriver.Printer();
            //Aclasdriver.
            obj_printer.Open();
            //Lib.Open();
             
            //Lib.Write(tmpfeed);
            obj_printer.Write(tmpfeed);

            for (int j = 0; j < 10; j++)
                //Lib.Write(tmpfeed);
                obj_printer.Write(tmpfeed);

            for (int j = 0; j < 2; j++)
            {

                // Lib.Write(testchar);
                obj_printer.Write(testchar);
        

                for (int i = 0; i < 30; i++)
                {
                    byte[] tmpbuf = { 0x0d, 0x0a };
                    //Lib.Write(tmpbuf);
                    obj_printer.Write(tmpbuf);
                }
                
            }

            for (int i = 0; i < 2; i++)
            {
                // Lib.Feed(5000);
                obj_printer.Feed(1000);
            }
        }
    }
}

