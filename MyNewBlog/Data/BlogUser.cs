namespace MyNewBlog.Data;

// Add profile data for application users by adding properties to the BlogUser class
public class BlogUser : IdentityUser
{
	[Required] [MaxLength(100)] public string FirstName { get; set; } = string.Empty;

	[Required] [MaxLength(100)] public string LastName { get; set; } = string.Empty;

	[Required] [MaxLength(50)] public string? DisplayName { get; set; }

	public ICollection<Comment>? Comments { get; set; }
}