using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using TeleperformanceProject.ShoppingList.Application.DTOs;
using TeleperformanceProject.ShoppingList.Application.Tokens;
using TeleperformanceProject.ShoppingList.Domain.Entities;
using TeleperformanceProject.ShoppingList.Domain.Entities.Identity;

namespace TeleperformanceProject.ShoppingList.Infrastructure.Services
{
    public class TokensHandler : ITokenHandler
    {
        readonly IConfiguration _configuration;
        readonly UserManager<User> _userManager;
        readonly RoleManager<Roles> _roleManager;
        public TokensHandler(IConfiguration configuration, UserManager<User> userManager, RoleManager<Roles> roleManager)
        {
            _configuration = configuration;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        
        public async Task<Token> CreateToken(int minute,User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                
            };
            var roles =  await _userManager.GetRolesAsync(user);
            AddRolesToClaims(claims, roles);

            Token token = new();
            SymmetricSecurityKey key = new(Encoding.UTF8.GetBytes(_configuration["Token:SecretKey"]));
            SigningCredentials signingCredentials = new(key, SecurityAlgorithms.HmacSha256);
            token.Expration = DateTime.UtcNow.AddMinutes(minute);
            JwtSecurityToken securityToken = new(
                audience: _configuration["Token:Audience"],
                issuer: _configuration["Token:Issuer"],
                expires: token.Expration,
                notBefore: DateTime.UtcNow,
                signingCredentials: signingCredentials,
                claims:claims
               
                );
            JwtSecurityTokenHandler tokenHandler = new();
            token.AccessToken = tokenHandler.WriteToken(securityToken);
            return token;

        }
        private void AddRolesToClaims(List<Claim> claims, IEnumerable<string> roles)
        {
            foreach (var role in roles)
            {
                var roleClaim = new Claim(ClaimTypes.Role, role);
                claims.Add(roleClaim);
            }
        }
    }
} 

