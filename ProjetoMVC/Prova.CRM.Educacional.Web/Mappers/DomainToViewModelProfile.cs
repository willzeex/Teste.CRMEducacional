namespace Prova.CRM.Educacional.Web.Mappers
{
    using AutoMapper;
    using Domain.Entities;
    using Domain.Entities.Integracao;
    using Models;

    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Aluno, AlunoViewModel>();
            CreateMap<Candidato, CandidatoViewModel>();
            CreateMap<Sala, SalaViewModel>()
                .ForMember(dest => dest.TotalVagas, opt => opt.MapFrom(src => src.TotalVagas))
                .ForMember(dest => dest.Candidatos, opt => opt.MapFrom(src => src.Candidatos));
        }
    }
}