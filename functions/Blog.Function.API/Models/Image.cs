using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
namespace Blog.Function.API.Models
{
    /// <summary>
    /// The model of a Image
    /// </summary>
    public class Image {
        /// <summary>
        /// The URL of the image
        /// </summary>
        [BsonElement("Url")]
        public string? Url {get; set;}

        /// <summary>
        /// The alt text of the image
        /// </summary>
        [BsonElement("AltText")]
        public string? AltText {get; set;}

        /// <summary>
        /// The name of the image
        /// </summary>
        [BsonElement("Name")]
        public string? Name {get; set;}

        /// <summary>
        /// The description of the image
        /// </summary>
        [BsonElement("Description")]
        public string? Description {get; set;}
    }
}