using Article.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Article.Data.Concreate.EntityModel
{
    public class Article : IEntity
    {
        public Article()
        {
            this.Tags = new HashSet<Tag>();
        }

        [Key]
        public int Article_ID { get; set; }
        //[Display(Name = "Makale Başlığı")]
        //[Required(ErrorMessage = "Makale Başlığı Giriniz")]
        //[StringLength(50, ErrorMessage = "Makale Başlığı En Fazla 50 Karakter Olarak Giriniz")]
        public string Article_Header { get; set; }
        //[Display(Name = "Makale İçeriği")]
        //[Required(ErrorMessage = "Makale İçeriği Giriniz")]
        public string Article_Content { get; set; }
        public DateTime Article_InsertDate { get; set; }
        public DateTime Article_UpdateDate { get; set; }
        public bool Article_IsActive { get; set; }
        //[Display(Name = "Makale Kategori")]
        //[Required(ErrorMessage = "Makale Kategori Seçiniz")]
        public int Article_CategoryID { get; set; }
        public int Article_UserID { get; set; }
        public int MyProperty { get; set; }


        public virtual Category Category { get; set; }
        public virtual User User { get; set; }
        public virtual  ICollection<Tag> Tags { get; set; }


    }
}
