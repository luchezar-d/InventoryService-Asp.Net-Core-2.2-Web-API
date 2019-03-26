using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.Models;

namespace InventoryService.Services.Interfaces
{
    public interface IInventoryService
    {
        InventoryItems AddInventoryItem(InventoryItems items);
        Dictionary<string,InventoryItems> GetInventoryItems();
    }
}
