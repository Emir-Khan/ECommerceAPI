namespace ECommerceAPI.Application.DTOs.User
{
    public class UserDetail
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string[] Roles { get; set; }
    }
}
