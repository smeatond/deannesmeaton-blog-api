using MongoDB.Driver;
using Blog.Function.API.Models;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Function.API.Services 
{
    /// <summary>
    /// The Blog post service
    /// </summary>
    public class BlogPostService : IBlogPostService
    {
        /// <summary>
        /// Gets a list of blog posts
        /// </summary>
        /// <returns>A list of Blog Posts</returns>
        public List<BlogPost> GetBlogPosts() {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a blog post based on the id
        /// </summary>
        /// <param name="id">id of the blog post</param>
        /// <returns>A blog post with the id</returns>
        /// <exception cref="BlogPostNotFound">Blog Post Not Found exception</exception>
        public BlogPost GetBlogPost(string id) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates an exisiting blog post with the new post
        /// </summary>
        /// <param name="updatedPost">the updated post</param>
        /// <returns>The updated post</returns>
        /// <exception cref="BlogPostNotFound">Blog Post Not Found exception</exception>
        public BlogPost UpdateBlogPost(BlogPost updatedPost) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new blog post.
        /// </summary>
        /// <param name="newPost">The new blog post</param>
        /// <returns>Returns the new blog post</returns>
       public BlogPost CreateBlogPost(BlogPost newPost) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delets a blog post
        /// </summary>
        /// <returns>A blog post with the id</returns>
        /// <exception cref="BlogPostNotFound">Blog Post Not Found exception</exception>
        public void DeleteBlogPost(string id){
            throw new NotImplementedException();
        }
    }
}