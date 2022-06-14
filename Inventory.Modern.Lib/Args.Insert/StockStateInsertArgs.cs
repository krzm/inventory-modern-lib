using CommandDotNet;
using Inventory.Data;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Modern.Lib;

public class StockStateInsertArgs 
    : Model 
    , IArgumentModel
{
	[Operand(nameof(StockId))
        , Required
        , Range(1, int.MaxValue, ErrorMessage = IdError)]
	public int StockId { get; set; }

	[Operand(nameof(StateId))
        , Required
        , Range(1, int.MaxValue, ErrorMessage = IdError)]
	public int StateId { get; set; }
}