using CommandDotNet;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Modern.Lib;

public class ItemArgUpdate 
    : ArgUpdate
{
    [Option('n', nameof(Name)), MaxLength(25)]
    public string? Name { get; set; }

    [Option('c', nameof(ItemCategoryId)), Range(1, int.MaxValue, ErrorMessage = "Id must be greater than zero")]
    public int? ItemCategoryId { get; set; }

    [Option('d', nameof(ItemDetailId)), Range(1, int.MaxValue, ErrorMessage = "Id must be greater than zero")]
    public int? ItemDetailId { get; set; }
}