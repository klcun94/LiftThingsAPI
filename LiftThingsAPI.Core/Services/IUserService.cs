using System;
using System.Security.Claims;

namespace LiftThingsAPI.Core.Services
{
    public interface IUserService
    {
        ClaimsPrincipal User { get; }
        string CurrentUserId { get; }
    }
}