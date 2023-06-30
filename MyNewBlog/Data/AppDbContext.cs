namespace MyNewBlog.Data;

public class AppDbContext : DbContext
{
	private readonly IConfiguration _configuration;

	public AppDbContext(IConfiguration configuration)
	{
		_configuration = configuration;
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		base.OnConfiguring(optionsBuilder);
		optionsBuilder.UseSqlServer(_configuration.GetConnectionString("BlogDbConnection"));
	}

	public DbSet<Post> Posts { get; set; }

}