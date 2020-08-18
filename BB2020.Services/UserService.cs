using BB2020.Core;
using BB2020.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BB2020.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<User> CreateUser(User user)
        {
            await _unitOfWork.Users.AddAsync(user);
            await _unitOfWork.CommitAsync();
            return user;
        }

        public async Task DeleteUser(User user)
        {
             _unitOfWork.Users.Remove(user);
            await _unitOfWork.CommitAsync();
        }

        public async Task<User> GetUserById(int id)
        {
            return await _unitOfWork.Users.GetByIdAsync(id);
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _unitOfWork.Users.GetAllAsync();
        }

        public async Task UpdateUser(User userToBeUpdated, User user)
        {
            userToBeUpdated.Active = user.Active;
            userToBeUpdated.Email = user.Email;
            userToBeUpdated.FirstName = user.FirstName;
            userToBeUpdated.LastName = user.LastName;
            userToBeUpdated.PhotoPath = user.PhotoPath;
            userToBeUpdated.TcNo = user.TcNo;
            await _unitOfWork.CommitAsync();
        }
    }
}
