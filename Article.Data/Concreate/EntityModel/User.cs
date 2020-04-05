using Article.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Article.Data.Concreate.EntityModel
{
    public class User : IEntity
    {
        public User()
        {
            this.Articles = new HashSet<Article>();
            this.Comments = new HashSet<Comment>();
        }

        [Key]
        public int User_ID { get; set; }
        public string User_Name { get; set; }
        public string User_Surname { get; set; }
        public string User_Email { get; set; }
        public string User_UserName { get; set; }
        public string User_Password { get; set; }
        public bool User_IsActive { get; set; }


        public virtual ICollection<Article> Articles { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }


    }
}
