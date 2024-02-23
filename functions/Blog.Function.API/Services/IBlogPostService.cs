using Blog.Function.API.Models;
using System.Collections.Generic;


namespace Blog.Function.API.Services 
{
    /// <summary>
    /// Interface for blog post service
    /// </summary>
    public interface IBlogPostService 
    {
        /// <summary>
        /// Gets a list of blog posts
        /// </summary>
        /// <returns>A list of Blog Posts</returns>
        public List<BlogPost> GetBlogPosts();

        /// <summary>
        /// Gets a blog post based on the id
        /// </summary>
        /// <param name="id">id of the blog post</param>
        /// <returns>A blog post with the id</returns>
        /// <exception cref="BlogPostNotFound">Blog Post Not Found exception</exception>
        public BlogPost GetBlogPost(string id);

        /// <summary>
        /// Updates an exisiting blog post with the new post
        /// </summary>
        /// <param name="updatedPost">the updated post</param>
        /// <returns>The updated post</returns>
        /// <exception cref="BlogPostNotFound">Blog Post Not Found exception</exception>
        public BlogPost UpdateBlogPost(BlogPost updatedPost);

        /// <summary>
        /// Creates a new blog post.
        /// </summary>
        /// <param name="newPost">The new blog post</param>
        /// <returns>Returns the new blog post</returns>
        public BlogPost CreateBlogPost(BlogPost newPost);

        /// <summary>
        /// Delets a blog post
        /// </summary>
        /// <returns>A blog post with the id</returns>
        /// <exception cref="BlogPostNotFound">Blog Post Not Found exception</exception>
        public void DeleteBlogPost(string id);
    }
}