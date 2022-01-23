using CommandDotNet;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Modern.Lib;

public class ItemDetailArg : IArgumentModel
{
    [Operand(nameof(Width))]
    public double? Width { get; set; }

    [Operand(nameof(Depth))]
    public double? Depth { get; set; }

    [Operand(nameof(Heigth))]
    public double? Heigth { get; set; }

    [Operand(nameof(Diameter))]
    public double? Diameter { get; set; }

    [Operand(nameof(Volume))]
    public double? Volume { get; set; }

    [Operand(nameof(Description)), MaxLength(250)]
    public string? Description { get; set; }
}