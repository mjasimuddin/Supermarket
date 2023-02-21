using BLL.Entities.Identity;

namespace BLL.Interfaces
{
    public interface ITokenService
    {
         string CreateToken(AppUser user);
    }
}