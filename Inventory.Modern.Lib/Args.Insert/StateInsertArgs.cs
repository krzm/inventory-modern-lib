using CommandDotNet;
using Inventory.Data;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Modern.Lib;

public class StateInsertArgs 
    : Model 
    , IArgumentModel
{
	[Operand(nameof(Name))
        , Required
        , MaxLength(NameMaxLength)]
	public string? Name { get; set; }

    [Option('d', "description")
        , MaxLength(DescriptionMaxLength)]
    public string? Description { get; set; }

	[Operand(nameof(CategoryId))
        , Required
        , Range(1, int.MaxValue, ErrorMessage = IdError)]
	public int CategoryId { get; set; }
}