using CommandDotNet;
using Inventory.Data;
using ModelHelper;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Modern.Lib;

public abstract class ArgUpdate 
    : Model 
    , IArgumentModel
    , IId
{
    [Operand(
       nameof(Id))
       , Required
       , Range(1, int.MaxValue, ErrorMessage = IdError)]
    public int Id { get; set; }
}