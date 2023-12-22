using Icarus.Service.DTOs.Users;

namespace Icarus.Service.Interfaces.Users
{
    public interface IUserService
    {
        Task<bool> RemoveAsync (long id);
        Task<UserForResultDto> RetrieveByIdAsync(string id);
        Task<IEnumerable<UserForResultDto>> RetrieveAllAsync();
        Task<UserForResultDto> AddAsync (UserForCreationDto dto);
        Task<UserForResultDto> RetrieveByEmailAsync(string email);
    }
}
