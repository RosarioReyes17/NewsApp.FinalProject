using Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewsApp.WebAPI.Data;
using NewsApp.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogginController : ControllerBase
    {
        private readonly NewsApppContext context;
        private readonly ITokenProvider tokenProvider;

        public LogginController(NewsApppContext context, ITokenProvider tokenProvider)
        {
            this.context = context;
            this.tokenProvider = tokenProvider;
        }

        [HttpPost("Authenticate")]
        [AllowAnonymous]
        public ActionResult Authenticate([FromForm]string NombreUsuario, [FromForm] string Clave)
        {
            var connection = context.Database.GetDbConnection();
            var result = connection.QueryFirstOrDefault<Usuario>("UsersValidate", new { NombreUsuario, Clave }, commandType: System.Data.CommandType.StoredProcedure);

            if (result == null)
            {
                return BadRequest("Invalid credentials.");
            }

            int expirationInHour = 24;
            DateTime expiratiorn = DateTime.UtcNow.AddHours(expirationInHour);

            var token = tokenProvider.CreateToken(result, expiratiorn);

            return Ok(new 
            {
                token = token,
                expires_in = expirationInHour * 60 * 60
            });
        }
    }
}
