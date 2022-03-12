using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSA.Entities;

public class Category
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public Guid Id { get; set; }
    
    public string Name { get; set; }

    public string CategoryImage { get; set; }
    
    public ICollection<CategoryItem> CategoryItems { get; set; }
}