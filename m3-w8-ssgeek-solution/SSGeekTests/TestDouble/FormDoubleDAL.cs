using SSGeek.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSGeek.Models;

namespace SSGeekTests.TestDouble
{
    public class FormDoubleDAL : IForumPostDAL
    {
        public List<ForumPost> GetAllPosts()
        {
            return new List<ForumPost>()
            {
                new ForumPost { Id = 1, Message = "Test", PostDate = DateTime.Now, Subject = "Test Subj", Username= "Test" },
                new ForumPost { Id = 2, Message = "Test 2", PostDate = DateTime.Now, Subject = "Test Subj 2", Username= "Test 2" },
            };
        }

        public bool SaveNewPost(ForumPost post)
        {
            return true;
        }
    }
}
