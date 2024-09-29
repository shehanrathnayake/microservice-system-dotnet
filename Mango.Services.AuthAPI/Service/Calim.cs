using System.Security.Claims;

namespace Mango.Services.AuthAPI.Service
{
    internal class Calim : Claim
    {
        public Calim(string type, string value) : base(type, value)
        {
        }
    }
}