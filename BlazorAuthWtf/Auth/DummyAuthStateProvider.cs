using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace BlazorAuthWtf.Auth
{
    public class DummyAuthStateProvider : AuthenticationStateProvider
    {
        // called once or twice per circuit depending whether pre-rendering is enabled
        // no IIdentity in the ClaimsPrincipal means not authenticated
        public override Task<AuthenticationState> GetAuthenticationStateAsync() =>
            Task.FromResult(new AuthenticationState(new ClaimsPrincipal()));
    }
}
