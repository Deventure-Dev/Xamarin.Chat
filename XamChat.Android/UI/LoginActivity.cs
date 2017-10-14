using Android.App;
using Android.Content.PM;
using Android.Widget;
using XamChat.Core.ViewModels;
using XamChat.Shared;

namespace XamChat.Android.UI
{
    [Activity(Label = "Login Activity", ScreenOrientation = ScreenOrientation.Portrait)]
    public class LoginActivity : BaseActivity
    {
        public new LoginViewModel ViewModel
        {
            get { return (LoginViewModel) base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.activity_login);

            var emailLabel = FindViewById<TextView>(Resource.Id.tv_email);
            emailLabel.Text = EmailLabelHelper.GetEmailLabel();
        }
    }
}