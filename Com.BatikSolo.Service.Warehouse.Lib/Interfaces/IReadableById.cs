using System.Threading.Tasks;

namespace Com.BatikSolo.Service.Warehouse.Lib.Interfaces
{
    public interface IReadByIdable<TModel>
    {
        Task<TModel> ReadById(int id);
    }
}
