namespace Prova.CRM.Educacional.Web.Mappers
{
    using AutoMapper;

    public class AutoMapperConfig
    {
        public static void RegisterMappers()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelProfile>();
                x.AddProfile<ViewModelToDomainProfile>();
            });
        }
    }
}