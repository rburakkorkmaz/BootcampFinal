using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Concrete.FoundPetVM;
using EntityLayer.Concrete.MissingPetVM;
using EntityLayer.Concrete.PetVM;
using EntityLayer.Concrete.UserVM;

namespace FindMyPet
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<int?, int>().ConvertUsing((src, dest) => src ?? dest);
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User, UserPostDTO>().ReverseMap().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<User, UserPutDTO>().ReverseMap().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<User, PetUserGetDTO>().ReverseMap().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<Pet, PetDTO>().ReverseMap();
            CreateMap<Pet, PetPostDTO>().ReverseMap().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<Pet, PetPutDTO>().ReverseMap().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<Pet, UserPetGetDTO>().ReverseMap().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<FoundPet, FoundPetGetDTO>().ReverseMap();
            CreateMap<FoundPet, FoundPetPostPutDTO>().ReverseMap().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<MissingPet, MissingPetGetDTO>().ReverseMap();
            CreateMap<MissingPet, MissingPetPostPutDTO>().ReverseMap().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
        }

    }
}
