using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using NorthwindBupa.Entity.Dto;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBupa.Bll
{
    public class TokenManager
    {
        IConfiguration configuration;

        public TokenManager(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        //Token uretilecek metod
        public string CreateAccessToken(DtoLoginUser user)
        {
            //claims oluşturmak
            var claims = new[]
            {
                 new Claim(JwtRegisteredClaimNames.Sub, user.UserCode),
                 new Claim(JwtRegisteredClaimNames.Jti, user.UserID.ToString())
            };

            var claimsIdentity = new ClaimsIdentity(claims, "Token");

            //claims roller
            var claimsRoleList = new List<Claim>
            {
                new Claim("role", "Admin"),
                //new Claim("role2","")
            };

            //security key'in simetrigini alıyoruz
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Tokens:Key"]));

            //sifrelenmis kimlik olusturuyoruz
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            //token ayarlarini yapiyoruz
            var token = new JwtSecurityToken
                (
                 issuer: configuration["Tokens:Issuer"],//token dagıtıcı url
                 audience: configuration["Tokens:Issuer"],//erisilebilecek api'ler
                 expires: DateTime.Now.AddMinutes(5),//token suresini 5 dk. ayarladik, omrunu 5 dk.
                 notBefore: DateTime.Now, //token uretildikten sonra ne kdar sure sonra devreye girecegini ayarlıyoruz.
                 signingCredentials: cred,//kimligi verdik
                 claims: claimsIdentity.Claims//claims verdik
                );

            //token olusturmak sınıfı ile bir ornek alip token uretiyoruz

            var tokenHandler = new { token = new JwtSecurityTokenHandler().WriteToken(token) };

            return tokenHandler.token;
        }
    }
}

