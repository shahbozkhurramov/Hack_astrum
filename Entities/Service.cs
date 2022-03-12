using System.ComponentModel.DataAnnotations;

namespace MedTech.Entities;

public class Service
{
    [Key]
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public string Location { get; set; }

    public string ServiceImage { get; set; }
    
    public string CallCenter { get; set; }

    public Guid CategoryItemId { get; set; }

    public virtual CategoryItem CategoryItem { get; set; }
}