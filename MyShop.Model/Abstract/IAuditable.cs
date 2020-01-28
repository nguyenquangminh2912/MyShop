using System;
namespace MyShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreateDate { set; get; }
        string CreateBy { get; set; }
        DateTime? UpdateDate { get; set; }
        string UpdateBy { get; set; }
        bool Status { set; get; }
        string MetaKeyword { get; set; }
        string MetaDescription { get; set; }
    }
}
