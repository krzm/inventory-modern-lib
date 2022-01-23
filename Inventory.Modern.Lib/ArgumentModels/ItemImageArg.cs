using CommandDotNet;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Modern.Lib;

public class ItemImageArg : IArgumentModel
{
    [Operand(nameof(ItemId)), Range(1, int.MaxValue, ErrorMessage = "Id must be greater than zero")]
    public int ItemId { get; set; }

    [Operand, Required, MaxLength(250)]
    public string? Path { get; set; }
}