namespace ECommerceAPI.Application.Exceptions
{
    public class PasswordChangeFieldException : Exception
    {
        public PasswordChangeFieldException() : base("An Error Occurred While Changing Password")
        {
        }

        public PasswordChangeFieldException(string? message) : base(message)
        {
        }

        public PasswordChangeFieldException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
