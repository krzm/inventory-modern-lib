using CommandDotNet;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Modern.Lib;

public class ItemCategoryArg : IArgumentModel
{
    [Operand(nameof(Name)), Required, MaxLength(25)]
    public string? Name { get; set; }

    [Operand(nameof(Description)), Required, MaxLength(70)]
    public string? Description { get; set; }

    [Operand(nameof(ParentId)), Range(1, int.MaxValue, ErrorMessage = "Id must be greater than zero")]
    public int? ParentId { get; set; }
}