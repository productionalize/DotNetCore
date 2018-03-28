// <copyright file="UserRepository.cs" company="Microsoft">
// Open source
// </copyright>

namespace DotNetCore.Data
{
    using Interfaces;
    using Model;
    using DotNetCore.Context;
    using Microsoft.Extensions.Options;
    using System.Threading.Tasks;
    using MongoDB.Driver;
    using System.Collections.Generic;

    public class UserRepository : IUserRepository
    {
        private readonly UserContext context;

        public UserRepository(IOptions<Settings> settings)
        {
            context = new UserContext(settings);
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await context.Users.Find(_ => true).ToListAsync();
        }

        public async Task<User> Get(string id)
        {
            return await context.Users
                .Find(u => u.UserId == id)
                .FirstOrDefaultAsync();
        }

        public async Task Create(User item)
        {
            await context.Users.InsertOneAsync(item);
        }

        public async Task<bool> Delete(string id)
        {
            DeleteResult actionResult = await context.Users.DeleteOneAsync(
                Builders<User>.Filter.Eq("Id", id));

            return actionResult.IsAcknowledged
                   && actionResult.DeletedCount > 0;
        }

        public async Task<bool> Update(string id, User item)
        {
            ReplaceOneResult actionResult = await context.Users
                .ReplaceOneAsync(n => n.UserId == id, item, new UpdateOptions { IsUpsert = true });
            return actionResult.IsAcknowledged
                   && actionResult.ModifiedCount > 0;
        }
    }
}