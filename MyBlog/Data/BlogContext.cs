using Microsoft.EntityFrameworkCore;

namespace MyBlog.Data
{
	public class BlogContext : DbContext
	{
		public BlogContext(DbContextOptions<BlogContext> options) : base(options)
		{
		}
	}
}
