using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jilani_Cards
{
    static class CVars
    {
        static string appName = "ASR Technologies";
        static string mobNo = "+92-330-3714438";
        static string emailID = "abdulsamadattariqadri@gmail.com";

        static string userid;
        static string username;


        static Form frmlogin;


        public static string getAppName
        {
            get
            {
                return appName;
            }
        }

        public static string getEmailID
        {
            get
            {
                return emailID;
            }
        }

        public static string getMobileNo
        {
            get
            {
                return mobNo;
            }
        }


        public static String setUserID
        {
            get
            {
                return userid;
            }

            set
            {
                userid = value;
            }
        }



        public static String setUserName
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }


        public static Form storeFormObject
        {
            get
            {
                return frmlogin;
            }

            set
            {
                frmlogin = value;
            }
        }


    }
}
