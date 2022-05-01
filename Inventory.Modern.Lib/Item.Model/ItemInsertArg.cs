using CommandDotNet;
using Inventory.Data;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Modern.Lib;

public class ItemInsertArg 
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

	[Operand(nameof(CategoryId))
        , Required
        , Range(1, int.MaxValue, ErrorMessage = IdError)]
	public int CategoryId { get; set; }

	[Operand(nameof(SizeId))
        , Range(1, int.MaxValue, ErrorMessage = IdError)]
	public int? SizeId { get; set; }
}