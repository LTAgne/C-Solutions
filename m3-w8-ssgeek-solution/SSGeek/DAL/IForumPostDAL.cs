using SSGeek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSGeek.DAL
{
    public interface IForumPostDAL
    {
        List<ForumPost> GetAllPosts();
        bool SaveNewPost(ForumPost post);
    }
}
