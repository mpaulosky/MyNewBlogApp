namespace MyNewBlog.Data;

public class MyNewBlogContext : IdentityDbContext<BlogUser>
{
  private readonly IConfiguration _configuration;

  public MyNewBlogContext(DbContextOptions<MyNewBlogContext> options, IConfiguration configuration)
        : base(options)
  {
    _configuration = configuration;

  }
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    base.OnConfiguring(optionsBuilder);
    optionsBuilder.UseSqlServer(_configuration.GetConnectionString("BlogDbConnection"));
  }
}
