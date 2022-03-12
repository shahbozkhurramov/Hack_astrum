using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CSA.Entities
{
    public class CategoryItem
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }
        
        public string Name { get; set; }

        public string CategoryItemImage { get; set; }

        public Guid CategoryId { get; set; }

        public virtual Category Category { get; set; }
        
        public ICollection<Service> Services { get; set; }
    }
}