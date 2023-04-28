namespace ECommerceAPI.Application.Features.Commands.AppUser.VerifyResetToken
{
    public class VerifyResetTokenCommandResponse
    {
        public bool State { get; set; }
        public string? Email { get; set; }
    }
}
