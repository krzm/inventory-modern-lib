using CommandDotNet;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Modern.Lib;

public class ContainerUpdateArg 
    : ArgUpdate
{
    [Option('n'
        , nameof(Name))
        , MaxLength(NameMaxLength)]
    public string? Name { get; set; }

    [Option('d'
        , nameof(Description))
        , MaxLength(DescriptionMaxLength)]
    public string? Description { get; set; }

    [Option('c'
        , nameof(CategoryId))
        , Range(1, int.MaxValue, ErrorMessage = IdError)]
    public int? CategoryId { get; set; }

    [Option('s'
        , nameof(SizeId))
        , Range(1, int.MaxValue, ErrorMessage = IdError)]
    public int? SizeId { get; set; }
}