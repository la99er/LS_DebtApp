using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LS_DebtApp.Helper
{
    public static class Constants
    {
        public static readonly string AddIcon;
        public static readonly string SettingsIcon;

        public static readonly string AcceptIcon;
        public static readonly string CancelIcon;
        public static readonly string ContactsIcon;
        public static readonly string LogoBig;

        /// <summary>
        /// List of all supported themes.
        /// </summary>
        public static readonly List<string> Themes = new List<string>()
        {
            "Hell",
            "Dunkel"
        };

        /// <summary>
        /// List of all supported currencies.
        /// </summary>
        public static readonly List<string> Currencies = new List<string>()
        {
            "€",
            "$",
            "£"
        };

        static Constants()
        {

            string prePath = "";

            if (Device.RuntimePlatform == Device.UWP || Device.RuntimePlatform == Device.WinPhone)
            {
                prePath = "Assets/";
            }

            AddIcon = prePath + "ic_add.png";
            SettingsIcon = prePath + "ic_settings.png";

            AcceptIcon = prePath + "accept_icon.png";
            CancelIcon = prePath + "cancel_icon.png";
            ContactsIcon = prePath + "contacts_icon.png";
            LogoBig = prePath + "logo_big.png";
        }
    }
}
