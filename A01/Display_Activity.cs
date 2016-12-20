using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.OS;
using Android.Widget;
using Android.Graphics;


namespace A01
{
    [Activity(Label = "Display_Activity")]
    public class Display_Activity : Activity
    {
        protected Button mSendButton;
        protected Button mExitButton;
        protected Button mClearButton;
        protected Button mSendMatrix;
        protected ImageView iMap;

        private Aclasdriver.AclasLcd0 mAclasLcd0 = null;
        private int lcd0state = 0;
        private ImageView showview;
        protected Bitmap bLcdDotMatrix;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.display_activity);

            bLcdDotMatrix = BitmapFactory.DecodeResource(Resources, Resource.Drawable.ic_launcher);
            mSendButton = FindViewById<Button>(Resource.Id.button_send);
            mSendMatrix = FindViewById<Button>(Resource.Id.button_senddot);
            mExitButton = FindViewById<Button>(Resource.Id.button_exit);
            mClearButton = FindViewById<Button>(Resource.Id.clear);
            iMap = FindViewById<ImageView>(Resource.Id.imageView_show);
            showview = (ImageView)FindViewById(Resource.Id.imageView_show);
            mAclasLcd0 = new Aclasdriver.AclasLcd0();

           
            mSendButton.Click += (sender, f) => {

                try
                {
                    sendMessage();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            };

            mSendMatrix.Click += (sender, e) => {

               
                Bitmap testmap = Bitmap.CreateBitmap(Lib.GetWidth(), Lib.GetHeight(), Bitmap.Config.Argb8888);
                Canvas picCanvas = new Canvas(testmap);
                picCanvas.DrawColor(Color.White);
                Paint mPaint = new Paint();
                Typeface mType = Typeface.Create(Typeface.Monospace, TypefaceStyle.Normal);
                ColorFilter BLACK = new ColorFilter();
                mPaint.SetColorFilter(BLACK);
               // mPaint.TextSize(16);
                mPaint.SetTypeface(mType);
                picCanvas.DrawText("Aclas Printer", 0, 32, mPaint);


                showview.SetImageBitmap(testmap);
                mAclasLcd0.WriteBitMap(testmap);
            };

            mExitButton.Click += (sender, e) => {

                Finish();

            };

            mClearButton.Click += (sender, e) => {

                byte[] clear = {0x0c};
                mAclasLcd0.WriteMsg(clear);

            };


        }


        private void sendMessage()
        {
           
            EditText texto =FindViewById<EditText>(Resource.Id.edit_text_out);
            String message = texto.Text.ToString();
            byte[] send = Encoding.ASCII.GetBytes(message);
            if (message.Length > 0)
            {
                if (lcd0state > 0)
                {
                    mAclasLcd0.WriteMsg(send);
                }
            }

        }
    }
}