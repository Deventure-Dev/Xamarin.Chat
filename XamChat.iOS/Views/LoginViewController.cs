using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using ObjCRuntime;
using UIKit;
using XamChat.Core.ViewModels;
using XamChat.Shared;

namespace XamChat.iOS.Views
{
    //[Register("LoginViewController")]
    [MvxFromStoryboard(StoryboardName = "MainStoryboard_iPhone")]
    public partial class LoginViewController : MvxViewController<LoginViewModel>
    {
        public LoginViewController()
        {
        }

        public LoginViewController(IntPtr handle)
            : base(handle)
        {
        }

        private static bool UserInterfaceIdiomIsPhone
        {
            get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // ios7 layout
            if (RespondsToSelector(new Selector("edgesForExtendedLayout")))
            {
                EdgesForExtendedLayout = UIRectEdge.None;
            }

            MvxFluentBindingDescriptionSet<LoginViewController, LoginViewModel> set =
                this.CreateBindingSet<LoginViewController, LoginViewModel>();
            set.Bind(textField_Email).To(vm => vm.Email);
            set.Bind(textField_Password).To(vm => vm.Password);
            set.Bind(btn_Login).To(x => x.LoginCommand);
            set.Apply();

            var gestureRecognizer = new UITapGestureRecognizer(() =>
            {
                textField_Email.ResignFirstResponder();
                textField_Password.ResignFirstResponder();
            });

            View.AddGestureRecognizer(gestureRecognizer);

            label_Email.Text = EmailLabelHelper.GetEmailLabel();
        }
    }
}