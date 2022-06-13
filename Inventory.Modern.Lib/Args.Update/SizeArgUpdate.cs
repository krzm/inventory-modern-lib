using CommandDotNet;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Modern.Lib;

public class SizeArgUpdate : ArgUpdate
{
    [Option('w', nameof(Width))]
    public double? Width { get; set; }

    [Option('e', nameof(Depth))]
    public double? Depth { get; set; }

    [Option('i', nameof(Heigth))]
    public double? Heigth { get; set; }

    [Option('a', nameof(Diameter))]
    public double? Diameter { get; set; }

    [Option('v', nameof(Volume))]
    public double? Volume { get; set; }

    [Option('d', nameof(Description)), MaxLength(250)]
    public string? Description { get; set; }
}