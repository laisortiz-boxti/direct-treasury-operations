using System;
using System.Text.Json.Serialization;

namespace BoxTI.DirectTreasuryOperation.API.Models.Common
{
    public abstract class Entity
    {
        [JsonIgnore]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public Entity()
        {
        }

        public Entity(string id)
        {
            Id = id;
        }
    }
}
