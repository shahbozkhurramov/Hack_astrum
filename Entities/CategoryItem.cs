using System.ComponentModel.DataAnnotations;

namespace MedTech.Entities
{
    public class CategoryItem
    {
        [Key]
        public Guid Id { get; set; }
        
        public string Name { get; set; }

        public string CategoryItemImage { get; set; }

        public Guid CategoryId { get; set; }

        public virtual Category Category { get; set; }
        
        public ICollection<Service> Services { get; set; }
    }
}