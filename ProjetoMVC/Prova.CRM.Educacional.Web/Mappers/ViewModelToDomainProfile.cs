namespace Prova.CRM.Educacional.Web.Mappers
{
    using AutoMapper;
    using Domain.Entities;
    using Domain.Entities.Integracao;
    using Models;

    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<AlunoViewModel, Aluno>();
            CreateMap<CandidatoViewModel, Candidato>();
            CreateMap<SalaViewModel, Sala>()
                .ForMember(dest => dest.TotalVagas, opt => opt.MapFrom(src => src.TotalVagas))
                .ForMember(dest => dest.Candidatos, opt => opt.MapFrom(src => src.Candidatos));
        }
    }
}