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

namespace A01
{
    [Activity(Label = "Print_Activity")]
    public class Print_Activity : Activity
    {
        EditText text;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.printer_activity);

            
            Button print_doc = FindViewById<Button>(Resource.Id.print_doc);
            text = FindViewById<EditText>(Resource.Id.print_text);

            print_doc.Click += ClickEvent;

        }

        private void ClickEvent(object sender, EventArgs e)
        {
            byte[] testchar = new byte[100];
            byte[] tmpfeed = { 0xd, 0xa }; //Comando feedline

            Aclasdriver.Printer obj_printer = new Aclasdriver.Printer();
            testchar= Encoding.ASCII.GetBytes(text.Text);
            obj_printer.Open();
            obj_printer.Write(testchar);
            obj_printer.Write(tmpfeed);
            obj_printer.Feed(1000);
        }
    }
}