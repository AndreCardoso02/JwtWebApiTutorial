using System.Security.Claims;

namespace JwtWebApiTutorial.Service.UserServices
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public UserService(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        public string GetMyName()
        {
            var result = string.Empty;

            if (httpContextAccessor != null)
            {
                result = httpContextAccessor?.HttpContext?.User.FindFirstValue(ClaimTypes.Name);
            }

            return result;
        }
    }
}
