using AutoMapper;
using GeekShopping.Product.API.Data.ValueObjects;

namespace GeekShopping.Product.API.Config
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Model.Product, ProductVO>().ReverseMap();
        }
    }
}
