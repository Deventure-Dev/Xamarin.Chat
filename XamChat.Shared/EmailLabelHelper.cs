using System;
namespace XamChat.Shared
{
    public class EmailLabelHelper
    {
        public static string GetEmailLabel()
        {
#if __IOS__
            return "Email for iOS";
#endif
#if __ANDROID__
            return "Email for Android";
#endif
            return string.Empty;
        }
    }
}
