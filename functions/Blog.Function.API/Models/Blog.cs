using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Blog.Function.API.Models
{
    public class Blog {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Title")]
        public string Title { get; set; }

        [BsonElement("CreatedDate")]
        public Date CreatedDate { get; set; }

        [BsonElement("ModifiedDate")]
        public Date ModifiedDate { get; set; }

        [BsonElement("Author")]
        public string Author { get; set; }

        [BsonElement("FeaturedImage")]
        public string FeaturedImage { get; set; }

        [BsonElement("Entry")]
        public string Entry { get; set; }

        [BsonElement("Summary")]
        public string Summary { get; set; }

        [BsonElement("Published")]
        public bool Published { get; set; }

        [BsonElement("Keywords")]
        public IList<string> Keywords { get; set; }
    }
}