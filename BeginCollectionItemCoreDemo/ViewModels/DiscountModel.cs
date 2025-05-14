using System;
using System.ComponentModel.DataAnnotations;

namespace BeginCollectionItemCoreDemo.ViewModels;

public class DiscountModel
{
    [Required]
    public string Description { get; set; }
    [Range(1, 10, ErrorMessage = "{0} must be between {1} and {2}")]
    public double Value { get; set; }
}
