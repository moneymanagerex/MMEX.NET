using System;
using System.ComponentModel.DataAnnotations;

namespace MMEX.Common.Resources.Constants
{
    public class constPlatform
    {
        public enum enPlatform
        {
            [Display(Description = "Android")]
            Android,
            [Display(Description = "iOS")]
            iOS,
            [Display(Description = "Mono")]
            Mono,
            [Display(Description = "tvOS")]
            tvOS,
            [Display(Description = "Unknown")]
            Unknown,
            [Display(Description = "watchOS")]
            watchOS,
            [Display(Description = "Windows")]
            Windows,
            [Display(Description = "Windows Phone")]
            WindowsPhone,
            [Display(Description = "Windows Universal")]
            WindowsUniversal
        }

        public static enPlatform getCurrentPlatform()
        {
            enPlatform Platform = enPlatform.Unknown;

            if (Type.GetType("Mono.Runtime") != null)
            {
                Platform = enPlatform.Mono;
#if __IOS__
            Platform = enPlatform.iOS;
#endif
#if __TVOS__
            Platform = enPlatform.tvOS;
#endif
#if __WATCHOS__
            Platform = enPlatform.watchOS;
#endif
#if __ANDROID__
            Platform = enPlatform.Android;
#endif
            }
            else
            {
                Platform = enPlatform.Windows;
#if WINDOWS_PHONE_APP
            Platform = enPlatform.WindowsPhone;
#endif
#if WINDOWS_APP
            Platform = enPlatform.WindowsUniversal;
#endif
            }

            return Platform;
        }
    }
}
