using CommandDotNet;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Modern.Lib;

public class StockDetailArgUpdate : ArgUpdate
{
    [Option('d', nameof(Description)), MaxLength(250)]
    public string? Description { get; set; }
}