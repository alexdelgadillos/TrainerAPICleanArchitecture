using System.ComponentModel.DataAnnotations;

namespace TrainerApp.Core.Entities
{
    public class Pokemon 
    {
        [Key]
        public string Name { get; set; }
    }
}