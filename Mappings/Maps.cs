using Assessment.Model;
using AutoMapper;


namespace Assessment.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<Customer, CustomerReg>().ReverseMap();
            //CreateMap<Client, ClientDTO>().ReverseMap();
           
        }
    }
}
