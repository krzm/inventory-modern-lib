using CommandDotNet;
using Inventory.Data;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Modern.Lib;

public class StockContainerInsertArgs 
    : Model 
    , IArgumentModel
{
	[Operand(nameof(StockId))
        , Required
        , Range(1, int.MaxValue, ErrorMessage = IdError)]
	public int StockId { get; set; }

	[Operand(nameof(ContainerId))
        , Required
        , Range(1, int.MaxValue, ErrorMessage = IdError)]
	public int ContainerId { get; set; }
}