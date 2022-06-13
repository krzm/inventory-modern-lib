using CommandDotNet;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Modern.Lib;

public class ImageArgUpdate : ArgUpdate
{

    [Option('i', nameof(ItemId)), Range(1, int.MaxValue, ErrorMessage = "Id must be greater than zero")]
    public int? ItemId { get; set; }

    [Option('p', nameof(Path)), MaxLength(250)]
    public string? Path { get; set; }
}