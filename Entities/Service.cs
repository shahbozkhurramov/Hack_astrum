using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CSA.Entities;

public class Service
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public string Location { get; set; }

    public string ServiceImage { get; set; }
    
    public string CallCenter { get; set; }

    public Guid CategoryItemId { get; set; }

    public string Price { get; set; }

    public EStatus Status { get; set; }
}