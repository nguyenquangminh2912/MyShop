using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Model.Abstract
{
    public abstract class Audiable : IAuditable
    {
        public DateTime? CreateDate { set; get; }
        [MaxLength(100)]
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        [MaxLength(100)]
        public string UpdateBy { get; set; }
        public bool Status { set; get; }
        [MaxLength(256)]
        public string MetaKeyword { get; set; }
        [MaxLength(256)]
        public string MetaDescription { get; set; }

    }
}
