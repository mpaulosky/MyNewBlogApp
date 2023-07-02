namespace MyNewBlog.Data;

public class AppDbContext : IdentityDbContext<BlogUser>
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{
	}

	protected override void OnModelCreating(ModelBuilder builder)
	{
		base.OnModelCreating(builder);

		builder.Entity<Comment>()
			.HasOne(c => c.BlogUser)
			.WithMany(u => u.Comments)
			.HasForeignKey(c => c.BlogUserId)
			.IsRequired();

		builder.Entity<Comment>()
			.HasOne(c => c.Post)
			.WithMany(u => u.Comments)
			.HasForeignKey(c => c.PostId)
			.IsRequired();
	}

	public DbSet<Post> Posts { get; set; }
	public DbSet<Comment> Comments { get; set; }
}