using CommandDotNet;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Modern.Lib;

public class StockDetailArg : IArgumentModel
{
    [Operand, MaxLength(250)]
    public string? Description { get; set; }
}