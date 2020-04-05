using Article.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Article.Data.Concreate.EntityModel
{
    public class Comment : IEntity
    {
        public Comment()
        {

        }

        [Key]
        public int Comment_ID { get; set; }
        public string Comment_Content { get; set; }
        public  DateTime Comment_InsertDate { get; set; }
        public DateTime Comment_UpdateDate { get; set; }
        public bool Comment_IsActive { get; set; }
        public int Comment_UserID { get; set; }
        public int Comment_ArticleID { get; set; }


        public virtual User User { get; set; }
        public virtual Article Article { get; set; }

    }
}
