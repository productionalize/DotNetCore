// <copyright file="User.cs" company="Microsoft">
// Open source
// </copyright>

namespace DotNetCore.Model
{
    using System;
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class User
    {
        [BsonId]
        private ObjectId Id { get; set; }

        public string UserId => Id.ToString();

        public DateTime UpdatedOn { get; set; } = DateTime.Now;

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        [BsonElement("firstName")]
        public string FirstName { get; set; }

        [BsonElement("middleName")]
        public string MiddleName { get; set; }

        [BsonElement("lastName")]
        public string LastName { get; set; }

        [BsonElement("dateOfBirth")]
        public DateTime DateOfBirth { get; set; }

        [BsonElement("gender")]
        public string Gender { get; set; }
    }
}