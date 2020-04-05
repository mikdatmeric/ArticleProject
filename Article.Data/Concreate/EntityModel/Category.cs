using Article.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Article.Data.Concreate.EntityModel
{
    public class Category : IEntity
    {
        public Category()
        {
            this.Articles = new HashSet<Article>();
        }

        [Key]
        public int Category_ID { get; set; }
        public string Category_Name { get; set; }
        public bool Category_IsActive { get; set; }

        public virtual ICollection<Article> Articles { get; set; }

    }

    

}
