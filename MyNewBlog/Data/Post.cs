// ============================================
// Copyright (c) 2023. All rights reserved.
// File Name :     Post.cs
// Company :       mpaulosky
// Author :        Matthew Paulosky
// Solution Name : MyNewBlogApp
// Project Name :  MyNewBlog
// =============================================

namespace MyNewBlog.Data;

public class Post
{
	public int Id { get; set; }
	public string Title { get; set; } = "";
	public string Introduction { get; set; } = "";
	public string Body { get; set; } = "";
	public string Author { get; set; } = "";
	public DateTimeOffset Created { get; set; } = DateTimeOffset.UtcNow;
	public string ImageName { get; set; } = "";
}