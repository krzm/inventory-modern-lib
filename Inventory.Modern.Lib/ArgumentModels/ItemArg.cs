using CommandDotNet;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Modern.Lib;

public class ItemArg : IArgumentModel
{
	[Operand(nameof(Name)), Required, MaxLength(25)]
	public string? Name { get; set; }

	[Operand(nameof(ItemCategoryId)), Required, Range(1, int.MaxValue, ErrorMessage = "Id must be greater than zero")]
	public int ItemCategoryId { get; set; }

	[Operand(nameof(ItemDetailId)), Range(1, int.MaxValue, ErrorMessage = "Id must be greater than zero")]
	public int? ItemDetailId { get; set; }
}