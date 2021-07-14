using System;
using System.Threading.Tasks;
using Domain.ApiModel;
using Domain.Repository;

namespace Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            if (userRepository == null)
                throw new NotImplementedException(nameof(IUserRepository));
            
            _userRepository = userRepository;
        }

        public async Task<bool> Authenticate(AuthenticationRequest model)
        {
            var user = await _userRepository.GetUserByUsername(model.Username);

            if (user == null)
                return false;

            // Compare hashes instead of plain text
            if (user.Password != model.Password)
                return false;
            
            return true;
        }
    }
}