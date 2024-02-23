using System;

namespace Blog.Function.API.Exceptions
{
    /// <summary>
    /// Exception for blog post not found
    /// </summary>
    public class BlogPostNotFound : Exception
    {
        /// <summary>
        /// Blog post not found exception
        /// </summary>
        public BlogPostNotFound()
        {
        }

        /// <summary>
        /// Blog Post Not Found exception
        /// </summary>
        /// <param name="blogPostID">The blog post id</param>
        public BlogPostNotFound(string blogPostID)
            : base(GetErrorMessage(blogPostID))
        {
        }

        /// <summary>
        /// Blog Post Not Found exception
        /// </summary>
        /// <param name="blogPostID">The blog post id</param>
        /// <param name="inner">The inner exception</param>
        public BlogPostNotFound(string blogPostID, Exception inner)
            : base(GetErrorMessage(blogPostID), inner)
        {
        }

        /// <summary>
        /// Gets the error message correctly formated
        /// </summary>
        /// <param name="BlogPostID">The blog post id</param>
        /// <returns>The message: Could not find blog post with id: {blogPostID} </returns>
        private static string GetErrorMessage(string blogPostID) => $"Could not find blog post with id: {blogPostID}";
    }
}