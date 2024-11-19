namespace ECommerceAPI.Application.DTOs.User
{
    public class CreateUserResponse
    {
        public string UserId { get; set; }
        public bool Succeeded { get; set; }
        public string Message { get; set; }
    }
}
