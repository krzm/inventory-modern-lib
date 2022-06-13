using CommandDotNet;
using Inventory.Data;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Modern.Lib;

public class ContainerInsertArgs 
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

    [Option('p', "parentId")
        , Range(1, int.MaxValue, ErrorMessage = IdError)]
	public int? ParentId { get; set; }

	[Option('s', "sizeId")
        , Range(1, int.MaxValue, ErrorMessage = IdError)]
	public int? SizeId { get; set; }
}