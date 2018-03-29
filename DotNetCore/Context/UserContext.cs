// <copyright file="UserContext.cs" company="Microsoft">
// Open source
// </copyright>

namespace DotNetCore.Context
{
    using Model;
    using Microsoft.Extensions.Options;
    using MongoDB.Driver;

    public class UserContext
    {
        private readonly IMongoDatabase database;

        public UserContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            database = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<User> Users => database.GetCollection<User>("User");
    }
}