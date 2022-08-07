using Microsoft.Extensions.Options;

namespace PortfolioApi.Security
{
    public class JwtTokenHandler
    {
        private readonly RequestDelegate _next;
        private readonly AppSettings _appSettings;

        public JwtTokenHandler(RequestDelegate next, IOptions<AppSettings> appSettings)
        {
            _next = next;
            _appSettings = appSettings.Value;
        }

        public async Task Invoke(HttpContext context, IJwtTokenManager jwtUtils)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            var userId = jwtUtils.ValidateJwtToken(token);
            //if (userId != null)
            //{
            //    // attach user to context on successful jwt validation
            //    context.Items["User"] = userService.GetById(userId.Value);
            //}

            await _next(context);
        }
    }
}
