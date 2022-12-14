using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearningEFCore.Entities
{
    [Table("BlogPost")]
    public class BlogPost
    {
        [Key]
        public int Id { get; set; }

        [Column("blogpost_title")]
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        //ForeignKey
        public int UserId { get; set; }
        //Navigation Property
        public User User { get; set; }
    }
}
