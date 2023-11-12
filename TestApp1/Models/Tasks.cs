using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestApp1.Models
{
    public class Tasks
    {
        [Key]
        public int Id { get;set; }

        [Column (TypeName= "nvarchar(50)")]
        public string Name { get;set; }
        [Column(TypeName = "nvarchar(200)")]
        public string Description { get;set; }
        public DateTime CreationDate { get;set; }
        public DateTime FinishedDate { get; set; }

        public bool IsCompleted { get; set; }


       
    }
}
