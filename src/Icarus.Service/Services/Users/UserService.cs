using AutoMapper;
using System.Data;
using Icarus.Domain.Entities;
using Icarus.Service.Exceptions;
using Icarus.Service.DTOs.Users;
using Microsoft.EntityFrameworkCore;
using Icarus.Data.IRepositories.Users;
using Icarus.Service.Interfaces.Users;

namespace Icarus.Service.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<UserForResultDto> AddAsync(UserForCreationDto dto)
        {
            var addUser = await _userRepository.SelectAll()
                .Where(u => u.Email.ToLower() == dto.Email.ToLower())
                .FirstOrDefaultAsync();

            if (addUser is not  null)
                throw new IcarusException(409, "User alredy exists");

            var mapped = _mapper.Map<User>(dto);
            mapped.CreatedAt = DateTime.UtcNow;

            var result = await _userRepository.InsertAsync(mapped);

            return _mapper.Map<UserForResultDto>(result);
        }

        public async Task<bool> RemoveAsync(long id)
        {
           var removeUser = await _userRepository.SelectAll()
                .Where (u => u.Id == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (removeUser is null)
                throw new IcarusException(404, "User is not found !");

            await _userRepository.DeleteAsync(id);
            return true;
        }

        public async Task<IEnumerable<UserForResultDto>> RetrieveAllAsync()
        {
          var allUser = await _userRepository.SelectAll()
                .AsNoTracking()
                .ToListAsync();

            return  _mapper.Map<IEnumerable<UserForResultDto>>(allUser);
        }

        public async Task<UserForResultDto> RetrieveByEmailAsync(string email)
        {
            var emailUser = await _userRepository.SelectAll()
                .Where(u => u.Email == email)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (emailUser is null)
                throw new IcarusException(404, "User is not found! ");

            return _mapper.Map<UserForResultDto>(emailUser);

        }

        public async Task<UserForResultDto> RetrieveByIdAsync(string id)
        {
            var byIdUser = await _userRepository.SelectAll()
                .Where(u => u.Id.Equals(id))
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (byIdUser is null)
                throw new IcarusException(404, "User is not found! ");

            return _mapper.Map<UserForResultDto>(byIdUser);
        }
    }
}
