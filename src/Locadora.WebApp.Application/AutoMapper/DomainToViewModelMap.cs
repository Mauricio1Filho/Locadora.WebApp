using AutoMapper;
using Locadora.WebApp.Domain.Models;
using Locadora.WebApp.ViewModel;

namespace Locadora.WebApp.Application.AutoMapper
{
    public class DomainToViewModelMap : Profile
    {
        public DomainToViewModelMap()
        {
            CreateMap<ClienteModel, ClientViewModel>();
            CreateMap<UsuarioModel, LoginViewModel>()
                .ForMember(dest => dest.login, opt => opt.MapFrom(src => src.Login))
                .ForMember(dest => dest.senha, opt => opt.MapFrom(src => src.Senha));
        }
    }
}
