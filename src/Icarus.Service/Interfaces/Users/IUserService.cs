using Icarus.Service.DTOs.Users;

namespace Icarus.Service.Interfaces.Users
{
    public interface IUserService
    {
        Task<bool> RemoveAsync (long id);
        Task<UserForResultDto> RetrieveByIdAsync(long id);
        Task<IEnumerable<UserForResultDto>> RetrieveAllAsync();
        Task<UserForResultDto> AddAsync (UserForCreationDto dto);
        Task<UserForResultDto> RetrieveByEmailAsync(string email);
        Task<UserForResultDto> ModifyAsync(long id, UserForUpdateDto dto);
    }
}
