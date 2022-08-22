using System;
using System.Collections.Generic;
using Com.BatikSolo.Service.Warehouse.Lib.Models.InventoryModel;

namespace Com.BatikSolo.Service.Warehouse.Lib.Interfaces.InventoryLoaderInterfaces
{
    public interface IInventoryLoader
    {
        Tuple<List<Inventory>, int, Dictionary<string, string>> Read(int Page = 1, int Size = 25, string Order = "{}", string Keyword = null, string Filter = "{}");
    }
}
