using CommandDotNet;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Modern.Lib;

public class CategoryArgUpdate 
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

    [Option('p'
        , nameof(ParentId))
        , Range(1, int.MaxValue, ErrorMessage = IdError)]
    public int? ParentId { get; set; }
}