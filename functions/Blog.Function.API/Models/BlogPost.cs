using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Blog.Function.API.Models
{
    /// <summary>
    /// The model of a blog post
    /// </summary>
    public class BlogPost {
        /// <summary>
        /// The post ID (from Mongo)
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        /// <summary>
        /// The title of the post
        /// </summary>
        [BsonElement("Title")]
        public string? Title { get; set; }

        /// <summary>
        /// The post created date
        /// </summary>

        [BsonElement("CreatedDate")]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// The modified date
        /// </summary>

        [BsonElement("ModifiedDate")]
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// The author
        /// </summary>

        [BsonElement("Author")]
        public string? Author { get; set; }

        /// <summary>
        /// The featured Image
        /// </summary>

        [BsonElement("FeaturedImage")]
        public Image? FeaturedImage { get; set; }

        /// <summary>
        /// The blog entry
        /// </summary>
        [BsonElement("Entry")]
        public string? Entry { get; set; }

        /// <summary>
        /// The summary
        /// </summary>

        [BsonElement("Summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// <true> if blog post is published
        /// <false> if blog post is not published
        /// </summary>

        [BsonElement("Published")]
        public bool Published { get; set; }

        /// <summary>
        /// Keywords of the blog post
        /// </summary>

        [BsonElement("Keywords")]
        public IList<string>? Keywords { get; set; }
    }
}