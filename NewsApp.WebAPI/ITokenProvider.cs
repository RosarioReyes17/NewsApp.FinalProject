using Microsoft.IdentityModel.Tokens;
using NewsApp.WebAPI.Models;
using System;

namespace NewsApp.WebAPI
{
    public interface ITokenProvider
    {
        string CreateToken(Usuario usuario, DateTime expirationDate);
        TokenValidationParameters GetValidationParameters();
    }
}