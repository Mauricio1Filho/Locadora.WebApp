using AutoMapper;
using Locadora.WebApp.Domain.Models;
using Locadora.WebApp.ViewModel;

namespace Locadora.WebApp.Application.AutoMapper
{
    public class ViewModelToDomainMap : Profile
    {
        public ViewModelToDomainMap()
        {
            CreateMap<ClientViewModel, ClienteModel>();
            CreateMap<LoginViewModel, UsuarioModel>()
                .ForMember(dest => dest.Login, opt => opt.MapFrom(src => src.login))
                .ForMember(dest => dest.Senha, opt => opt.MapFrom(src => src.senha));
        }
    }
}
