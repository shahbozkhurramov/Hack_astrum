using System.ComponentModel.DataAnnotations;

namespace MedTech.Entities;

public class Category
{
    [Key]
    public Guid Id { get; set; }
    
    public string Name { get; set; }

    public string CategoryImage { get; set; }
    
    public ICollection<CategoryItem> CategoryItems { get; set; }
}