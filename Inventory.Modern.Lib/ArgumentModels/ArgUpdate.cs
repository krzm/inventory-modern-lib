using CommandDotNet;
using Core;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Modern.Lib;

public abstract class ArgUpdate : IArgumentModel, IId
{
    [Operand(
       "id")
       , Required
       , Range(1, int.MaxValue, ErrorMessage = "Id must be greater than zero")]
    public int Id { get; set; }
}
