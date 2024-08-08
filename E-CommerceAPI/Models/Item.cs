using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace E_CommerceAPI.Models
{
    public class Item
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [JsonPropertyName("Id")]
        public string? Id { get; set; }

        [BsonRepresentation(BsonType.String)]
        [JsonPropertyName("SerialNo")]
        public string SerialNo { get; set; } = null!;

        [BsonRepresentation(BsonType.String)]
        [JsonPropertyName("ProductBrand")]
        public string ProductBrand { get; set; } = null!;

        [BsonRepresentation(BsonType.String)]
        [JsonPropertyName("ProductName")]
        public string ProductName { get; set; } = null!;

        [BsonRepresentation(BsonType.String)]
        [JsonPropertyName("Category")]
        public string Category { get; set; } = null!;

        [BsonRepresentation(BsonType.String)]
        [JsonPropertyName("SubCategory")]
        public string SubCategory { get; set; } = null!;

        [BsonRepresentation(BsonType.Decimal128)]
        [JsonPropertyName("Price")]
        public decimal Price { get; set; } = 0;

        [BsonRepresentation(BsonType.String)]
        [JsonPropertyName("Description")]
        public string Description { get; set; } = null!;

        [BsonRepresentation(BsonType.Int32)]
        [JsonPropertyName("StockAmount")]
        public int StockAmount { get; set; } = 0;

        [BsonElement("items")]
        [JsonPropertyName("Attributes")]
        public List<string> Features { get; set; } = [];
    }
}
