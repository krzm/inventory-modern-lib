using CommandDotNet;
using Inventory.Data;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Modern.Lib;

public class CategoryArg 
    : Model
    , IArgumentModel
{
    [Operand(nameof(Name))
        , Required
        , MaxLength(NameMaxLength)]
    public string? Name { get; set; }

    [Operand(nameof(Description))
        , Required
        , MaxLength(DescriptionMaxLength)]
    public string? Description { get; set; }

    [Operand(nameof(ParentId))
        , Range(1, int.MaxValue, ErrorMessage = IdError)]
    public int? ParentId { get; set; }
}