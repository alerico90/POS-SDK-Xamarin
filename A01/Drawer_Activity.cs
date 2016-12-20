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
    [Activity(Label = "Drawer_Activity")]
    public class Drawer_Activity : Activity
    {
        private Aclasdriver.Drawer mdrawer;
        private int fd;
        private Button OpenButton;
        public static String tag = "AclasArmPosDBG";

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.drawer_activity);
            mdrawer = new Aclasdriver.Drawer();
            OpenButton = FindViewById<Button>(Resource.Id.DrawerButton);
            OpenButton.Click += (sender, f) =>
            {
                mdrawer.Open();
            };
        }
    }
}