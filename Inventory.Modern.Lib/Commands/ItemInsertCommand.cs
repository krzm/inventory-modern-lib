﻿using AutoMapper;
using CLI.Core;
using CLI.Core.Lib;
using Inventory.Data;

namespace Inventory.Modern.Lib;

public class ItemInsertCommand
    : InsertCommand<IInventoryUnitOfWork, Item, ItemArg>
{
    public ItemInsertCommand(
        IInventoryUnitOfWork unitOfWork
        , IOutput output
        , IMapper mapper)
            : base(unitOfWork, output, mapper)
    {
    }

    protected override void InsertEntity(Item entity) =>
        UnitOfWork.Item.Insert(entity);
}