

namespace Blog.Function.API.Models
{
    /// <summary>
    /// Model of the Blog database settings
    /// </summary>
    public class BlogDatabaseSettings 
    {
        /// <summary>
        /// The collection name in the database
        /// </summary>
        public string? CollectionName { get; set; }
        /// <summary>
        /// The connection string
        /// </summary>
        public string? ConnectionString { get; set; }
        /// <summary>
        /// The database name
        /// </summary>
        public string? DatabaseName { get; set; }
    }
}