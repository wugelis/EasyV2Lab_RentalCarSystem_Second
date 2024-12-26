using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyArchitectV2Lab.JWTMiddleware
{
    public static class JwtCustomAuthentication
    {
        public static IApplicationBuilder UseJWTCustomAuthentication(this IApplicationBuilder app)
        {
            return app.UseMiddleware<JwtService>();
        }
    }
}
