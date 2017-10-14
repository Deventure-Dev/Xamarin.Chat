// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XamChat.iOS.Views
{
    [Register ("LoginViewController")]
    partial class LoginViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btn_Login { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel label_Email { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textField_Email { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textField_Password { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btn_Login != null) {
                btn_Login.Dispose ();
                btn_Login = null;
            }

            if (label_Email != null) {
                label_Email.Dispose ();
                label_Email = null;
            }

            if (textField_Email != null) {
                textField_Email.Dispose ();
                textField_Email = null;
            }

            if (textField_Password != null) {
                textField_Password.Dispose ();
                textField_Password = null;
            }
        }
    }
}