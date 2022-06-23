using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Endpoints
{
    public class APIEndpoints
    {
        private const string BASE_URL = "https://wema-alatdev-apimgt.azure-api.net/alat-test/api/Shared";
        public static string Get_All_Banks = BASE_URL+ "/GetAllBanks";
    }
}
