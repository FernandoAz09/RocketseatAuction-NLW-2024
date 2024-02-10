using RocketseatAuction.API.Entities;
using System.Security.Cryptography.X509Certificates;

namespace RocketseatAuction.API.Contracts;

public interface IUserRepository
{
    bool ExistUserWithEmail(string email);
    User GetUserByEmail(string email);
}
