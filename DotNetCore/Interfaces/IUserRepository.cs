// <copyright file="IUserRepository.cs" company="Microsoft">
// Open source
// </copyright>

namespace DotNetCore.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Model;

    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAll();

        Task<User> Get(string id);

        // add new User document
        Task Create(User item);

        // remove a single document / User
        Task<bool> Delete(string id);

        // update just a single document / User
        Task<bool> Update(string id, User user);
    }
}