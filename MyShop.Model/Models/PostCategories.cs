using MyShop.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShop.Model.Models
{
    public  class PostCategories:Audiable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Column(TypeName ="nvarchar(150)")]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        [Required]
        public string Alias { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        [Required]
        public string Description { get; set; }
        public int? ParentID { get; set; }
        public int? DisplayOrder { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required]
        public string Image { get; set; }
        public bool? HomeFlag { get; set; }
    }
}
