using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Torc.Common;

namespace Torc.Business;

public class Book : IEntity
{
    public int Id { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string Title { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string LastName { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string Type { get; set; }
    
    [Required]
    [MaxLength(80)]
    public string ISBN { get; set; }
    
    [MaxLength(100)]
    public string Publisher { get; set; }
    
    [MaxLength(50)]
    public string Category { get; set; }
    
    [Required]
    [DefaultValue(0)]
    public int TotalCopies { get; set; }
    
    [Required]
    [DefaultValue(0)]
    public int CopiesInUse { get; set; }
}