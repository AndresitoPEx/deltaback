using loginapp.Models;
using System.Security.Claims;
using System.Text;

namespace loginapp.Tools
{
    public class Jwt
    {
        public string ClaveToken = "werewr#$5435dsfdsfdsd";

        public string CreateToken(DatosUsuarioLogeado usuario)
        {
            var key = Encoding.ASCII.GetBytes(this.ClaveToken);

            // CREAMOS LOS CLAIMS

            ClaimsIdentity claimsIdentity = new ClaimsIdentity();
            claimsIdentity.AddClaim(new Claim( "usuarioId", "" ));
            claimsIdentity.AddClaim(new Claim("usuarioId", ""));
            claimsIdentity.AddClaim(new Claim("rol", ""));

            return null;
        }

        private DatosUsuarioLogeado DecompilarToken(string token)
        {
            return null;
        }

        public bool VerificarToken(string token)
        {
            return false;
        }
    }
}
