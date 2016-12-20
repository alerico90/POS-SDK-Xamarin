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
using System.Runtime.InteropServices;

namespace A01
{
    public class Lib
    {
       
        [DllImport("libAclasArmPos.so", EntryPoint = "Java_aclasdriver_printer_Open")]
        public static extern int Open( );

        [DllImport("libAclasArmPos.so", EntryPoint = "Java_aclasdriver_printer_Close")]
        public static extern void Close();

        [DllImport("libAclasArmPos.so", EntryPoint = "Java_aclasdriver_printer_Write")]
        public static extern int Write(byte[] wrbuf);

        [DllImport("libAclasArmPos.so", EntryPoint = "Java_aclasdriver_printer_Read")]
        public static extern  byte[] Read(int getlen);

        [DllImport("libAclasArmPos.so", EntryPoint = "Java_aclasdriver_printer_SetContrast")]
        public static extern int SetConstrast(int contrast);

        [DllImport("libAclasArmPos.so", EntryPoint = "Java_aclasdriver_printer_Feed")]
        public static extern int Feed(int setp);

        [DllImport("libAclasArmPos.so", EntryPoint = "Java_aclasdriver_printer_Stop")]
        public static extern int Stop();

        [DllImport("libAclasArmPos.so", EntryPoint = "Java_aclasdriver_printer_Conitnue")]
        public static extern int Continue();

        [DllImport("libAclasArmPos.so", EntryPoint = "Java_aclasdriver_printer_GetDotWidth")]
        public static extern int GetDotWidth();

        [DllImport("libAclasArmPos.so", EntryPoint = "Java_aclasdriver_printer_SetPrintMode")]
        public static extern int SetPrintMode(int Mode);

        [DllImport("libAclasArmPos.so", EntryPoint = "Java_aclasdriver_printer_IsPaperExist")]
        public static extern bool IfPaperExist();

        [DllImport("libAclasArmPos.so", EntryPoint = "Java_aclasdriver_AclasLcd0_GetWidth")]
        public static extern int GetWidth();

        [DllImport("libAclasArmPos.so", EntryPoint = "Java_aclasdriver_AclasLcd0_GetHeight")]
        public static extern int GetHeight();
    }
}