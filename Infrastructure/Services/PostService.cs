using Domain.Models;
namespace Infrastructure.Services;
public class PostService
{
    public PostService() {}
    List<Post> _post = new List<Post>();

    public List<Post> GetPost()
    {
        return _post;
    }
    public void AddPost(Post post)
    {
        _post.Add(post);
    }
    public string UpdateInfoOfPost(Post UpdatedPost)
    {
        foreach (var post in _post)
        {
            if (post.Id == UpdatedPost.Id)
            {
                post.Title = UpdatedPost.Title;
                post.Description = UpdatedPost.Description;
                post.VoteAmount = UpdatedPost.VoteAmount;
                post.CreateAI = UpdatedPost.CreateAI;
                return "Post's info is updated";
            }
        }
        return "Post not found";
    }
    public string DeletePost(int id)
    {
        foreach (var post in _post)
        {
            if (post .Id == id)
            {
                _post.Remove(post);
                return "Post deleted";
            }
        }
        return "Post not found";
    }
}
