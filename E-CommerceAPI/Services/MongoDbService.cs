using E_CommerceAPI.Models;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;

namespace E_CommerceAPI.Services
{
    public class MongoDbService
    {
        private readonly IMongoCollection<Item> _collection;

        public MongoDbService(IOptions<MongoDbSettings> mongoDbSettings)
        {
            MongoClient client = new MongoClient(mongoDbSettings.Value.ConnectionUri);
            IMongoDatabase database = client.GetDatabase(mongoDbSettings.Value.DatabaseName);
            _collection = database.GetCollection<Item>(mongoDbSettings.Value.CollectionName);
        }
        public async Task<List<Item>> GetAsync()
        {
            return await _collection.Find(new BsonDocument()).ToListAsync();
        }

        public async Task<Item> GetByIdAsync(string id)
        {
            FilterDefinition<Item> filter = Builders<Item>.Filter.Eq("Id", id);
            return await _collection.Find(filter).FirstOrDefaultAsync();
        }

        public async Task CreateAsync(Item item)
        {
            await _collection.InsertOneAsync(item);
        }

        public async Task UpdateAsync(string id, Item item)
        {
            FilterDefinition<Item> filter = Builders<Item>.Filter.Eq("Id", id);
            await _collection.ReplaceOneAsync(filter,item);
        }

        public async Task DeleteAsync(string id)
        {
            FilterDefinition<Item> filter = Builders<Item>.Filter.Eq("Id", id);
            await _collection.DeleteOneAsync(filter);
        }
    }
}
