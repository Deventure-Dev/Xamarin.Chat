using XamChat.Core.Interfaces;

namespace XamChat.Core.Services
{
    public class CoreValidationService : ICoreValidationService
    {
        #region private fields

        private const int INPUT_MIN_LENGTH = 3;
        private const int INPUT_MAX_LENGTH = 15;

        #endregion

        public bool IsValidLogin(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password))
            {
                return false;
            }
            if (email.Length >= INPUT_MIN_LENGTH && email.Length <= INPUT_MAX_LENGTH &&
                password.Length >= INPUT_MIN_LENGTH && password.Length <= INPUT_MAX_LENGTH)
            {
                return true;
            }
            return false;
        }
    }
}
