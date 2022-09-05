using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using mhcb.Syd.AppCenter.Services;
using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.AppCenter.Services.Interface;
using System.Net.Http.Json;
using System;

namespace mhcb.Syd.AppCenter.Services.API
{
    public class FacilityTypeService : IFacilityTypeService
    {
        private readonly HttpClient httpClient;
        public FacilityTypeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<int> InsertFacilityType(FacilityTypeAttribute facilityTypeAttr)
        {
            return await httpClient.PostJsonAsync<int>("api/FacilityType", facilityTypeAttr);
        }
    }
}
