using System.Windows.Input;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using XamChat.Core.Interfaces;

namespace XamChat.Core.ViewModels
{
    public class LoginViewModel : MvxViewModel
    {
        #region private fields

        private string mEmail;
        private string mPassword;
        private ICommand mLoginCommand;
        private ICoreValidationService mCoreValidationService;
        private INativeValidationService mNativeValidationService;

		#endregion

		public LoginViewModel(ICoreValidationService coreValidationService, 
                              INativeValidationService nativeValidationService)
		{
            //var myCoreValidationService = Mvx.Resolve<ICoreValidationService>();
			mCoreValidationService = coreValidationService;
			mNativeValidationService = nativeValidationService;
		}

        public string Email
        {
            get { return mEmail; }
            set { mEmail = value; RaisePropertyChanged(() => Email); }
        }

        public string Password
        {
            get { return mPassword; }
            set { mPassword = value; RaisePropertyChanged(() => Password); }
        }

		#region Commands Implementation

		public ICommand LoginCommand
        {
            get
            {
                mLoginCommand = mLoginCommand ?? new MvxCommand(DecideIfActive);
                return mLoginCommand;
            }
        }

        #endregion

        #region private methods

        private void DecideIfActive()
        {
            if (mCoreValidationService.IsValidLogin(mEmail, mPassword))
            {
                ShowViewModel<FriendsViewModel>();
                return;
            }
            mNativeValidationService.ShowNativeMessage("Invalid input at login.");
       }

        #endregion
    }
}
