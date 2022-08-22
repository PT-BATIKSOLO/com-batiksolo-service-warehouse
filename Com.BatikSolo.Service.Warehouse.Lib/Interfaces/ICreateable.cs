using System.Threading.Tasks;

namespace Com.BatikSolo.Service.Warehouse.Lib.Interfaces
{
    public interface ICreateable
    {
        Task<int> Create(object model);
    }
}
