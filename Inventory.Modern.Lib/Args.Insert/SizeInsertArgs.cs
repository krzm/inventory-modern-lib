using CommandDotNet;
using Inventory.Data;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Modern.Lib;

public class SizeInsertArgs 
    : Model
    , IArgumentModel
{
    private const string DimensionError = "Dimension must be greater than zero";

    [Operand(nameof(LengthUnitId))
        , Range(1, int.MaxValue, ErrorMessage = IdError)]
    public int LengthUnitId { get; set; }

    [Operand(nameof(VolumeUnitId))
        , Range(1, int.MaxValue, ErrorMessage = IdError)]
    public int VolumeUnitId { get; set; }

    [Option('l', "length")
        , Range(0.0, double.MaxValue, ErrorMessage = DimensionError)]
    public double? Length { get; set; }

    [Option('e', "heigth")
        , Range(0.0, double.MaxValue, ErrorMessage = DimensionError)]
    public double? Heigth { get; set; }

    [Option('d', "depth")
        , Range(0.0, double.MaxValue, ErrorMessage = DimensionError)]
    public double? Depth { get; set; }
    
    [Option('i', "diameter")
        , Range(0.0, double.MaxValue, ErrorMessage = DimensionError)]
    public double? Diameter { get; set; }

    [Option('v', "volume")
        , Range(0.0, double.MaxValue, ErrorMessage = DimensionError)]
    public double? Volume { get; set; }

    [Option('s', "desc")
        , MaxLength(DescriptionMaxLength)]
    public string? Description { get; set; }
}