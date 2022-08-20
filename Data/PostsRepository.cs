using Microsoft.EntityFrameworkCore;

namespace callList.Data
{
    internal static class PostsRepository
    {
        internal async static Task<List<Post>> GetPostsAsync()
        {
            using (var db= new AppDBContext())
            {
                return await db.Posts.ToListAsync();
            }
        }

        internal async static Task<Post> GetPostByIdAsync(int Id)
        {
            using (var db = new AppDBContext())
            {
                return await db.Posts.FirstOrDefaultAsync(post => post.Id == Id);
            }
        }

        internal async static Task<bool> CreatePostAsync(Post postToCreate)
        {
            using (var db = new AppDBContext())
            {
                try
                {
                    await db.Posts.AddAsync(postToCreate);
                    return await db.SaveChangesAsync() >= 1;
                }
                catch(Exception e)
                {
                    return false;
                }
            }
        }
    
    internal async static Task<bool> UpdatePostAsync(Post postToUpdate)
    {
        using (var db = new AppDBContext())
        {
            try
            {
                 db.Posts.Update(postToUpdate);
                return await db.SaveChangesAsync() >= 1;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }

        internal async static Task<bool> DeletePostAsync(int Id)
        {
            using (var db = new AppDBContext())
            {
                try
                {
                    Post postToDelete = await GetPostByIdAsync(Id);
                    db.Remove(postToDelete);
                       return await db.SaveChangesAsync() >= 1;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

    }
}
