using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.Models;



namespace WebApplication2.Data.Repository
{
    public interface IRepository
    {
        Post GetPost(int id);
        List<Post> GetAllPosts(int id);
        void AddPost(Post post);
        void RemovePost(int id);
        void UpdatePost(Post post);

        Task<bool> SaveChangesAsync();

    }
}
