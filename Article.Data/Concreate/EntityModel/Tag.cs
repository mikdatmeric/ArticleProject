using Article.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Article.Data.Concreate.EntityModel
{
    public class Tag : IEntity
    {
        public Tag()
        {
            this.Articles = new HashSet<Article>();
        }

        [Key]
        public int Tag_ID { get; set; }
        public string Tag_Name { get; set; }

        public virtual ICollection<Article> Articles { get; set; }

    }
}
