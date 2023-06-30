namespace MyNewBlog.Data;


public static class PostCreator
{

	/// <summary>
	///   Gets a new post.
	/// </summary>
	/// <param name="keepId">bool whether to keep the generated Id</param>
	/// <param name="useNewSeed">bool whether to use a seed other than 0</param>
	/// <returns>Post</returns>
	public static Post GetNewComment(bool keepId = false, bool useNewSeed = false)
	{
		var post = GenerateFake(useNewSeed).Generate();

		if (!keepId)
		{
			post.Id = 0;
		}

		return post;
	}

	/// <summary>
	///   Gets a list of posts.
	/// </summary>
	/// <param name="numberOfPosts">The number of posts.</param>
	/// <param name="useNewSeed">bool whether to use a seed other than 0</param>
	/// <returns>A List of Post</returns>
	public static List<Post> GetPosts(int numberOfPosts, bool useNewSeed = false)
	{
		var posts = GenerateFake(useNewSeed).Generate(numberOfPosts);

		return posts;
	}

	/// <summary>
	///   GenerateFake method
	/// </summary>
	/// <param name="useNewSeed">bool whether to use a seed other than 0</param>
	/// <returns>Fake Post</returns>
	private static Faker<Post> GenerateFake(bool useNewSeed = false)
	{
		var seed = 0;
		if (useNewSeed)
		{
			seed = Random.Shared.Next(10, int.MaxValue);
		}

		return new Faker<Post>()
			.RuleFor(x => x.Id, f => f.Random.Int(0, 100))
				.RuleFor(c => c.Title, f => f.Lorem.Sentence(10))
				.RuleFor(x => x.Introduction, f => f.Lorem.Paragraph(1))
				.RuleFor(x => x.Body, f => f.Lorem.Paragraph(4))
				.RuleFor(x => x.Author, f => f.Internet.UserName())
				.RuleFor(x => x.Created, f => f.Date.Past())
				.UseSeed(seed);
	}
}
