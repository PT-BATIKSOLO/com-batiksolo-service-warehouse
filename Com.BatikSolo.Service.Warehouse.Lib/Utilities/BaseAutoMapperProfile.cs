using AutoMapper;

namespace Com.BatikSolo.Service.Warehouse.Lib.Utilities
{
    public class BaseAutoMapperProfile : Profile
    {
        public BaseAutoMapperProfile()
        {
            //RecognizePrefixes("_");
            RecognizeAlias("_id", "Id");
        }
    }
}
