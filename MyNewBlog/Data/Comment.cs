namespace MyNewBlog.Data;

public class Comment
{
	public int Id { get; set; }
	public int PostId { get; set; }
	public string BlogUserId { get; set; } = "";
	public string CommentText { get; set; } = "";

	public DateTimeOffset Created { get; set; } = DateTimeOffset.UtcNow;

	public BlogUser BlogUser { get; set; } = default!;
	public Post Post { get; set; } = default!;
}