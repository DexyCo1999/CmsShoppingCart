using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //za [Key]
using System.ComponentModel.DataAnnotations.Schema; //za [Table("tblPages")]
using System.Linq;
using System.Web;

namespace CmsShoppingCart.Models.Data
{
    [Table("tblPages")]
    public class PageDTO
    {
        [Key] //primary key
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Body { get; set; }
        public int Sorting { get; set; }
        public bool HasSidebar { get; set; }
    }
}