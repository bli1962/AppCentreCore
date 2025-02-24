using AutoMapper;
using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.Models;

namespace mhcb.Syd.Api
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BisRate, BisRateViewModel>();
            CreateMap<BisRateViewModel, BisRate>();

            CreateMap<DepositsRate, DepositsRateViewModel>();
            CreateMap<DepositsRateViewModel, DepositsRate>();

            CreateMap<FxRate, FxRateViewModel>();
            CreateMap<FxRateViewModel, FxRate>();

            CreateMap<RevaluationRate, RevaluationRateViewModel>();
            CreateMap<RevaluationRateViewModel, RevaluationRate>();

            CreateMap<SwapRate, SwapRateViewModel>();
            CreateMap<SwapRateViewModel, SwapRate>();
        }
    }
}
