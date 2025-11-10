using System.Security.Claims;

namespace BlazorAutoCleanArch.WebApp.Extensions;

public static class ClaimsPrincipalExtensions
{
    public static string ObterEmail(this ClaimsPrincipal user)
    {
        return user.FindFirst(ClaimTypes.Email)?.Value
            ?? user.FindFirst("email")?.Value
            ?? "";
    }

    public static string ObterNome(this ClaimsPrincipal user)
    {
        return user.Identity?.Name ?? "";
    }
}
