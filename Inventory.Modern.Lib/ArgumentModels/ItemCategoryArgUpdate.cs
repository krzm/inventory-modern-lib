using CommandDotNet;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Modern.Lib;

public class ItemCategoryArgUpdate : ArgUpdate
{
    [Option('n', nameof(Name)), MaxLength(25)]
    public string? Name { get; set; }

    [Option('d', nameof(Description)), MaxLength(70)]
    public string? Description { get; set; }

    [Option('p', nameof(ParentId)), Range(1, int.MaxValue, ErrorMessage = "Id must be greater than zero")]
    public int? ParentId { get; set; }
}