using Assessment.Endpoints;
using Assessment.IServices;
using Assessment.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Assessment.Services
{
    public class BankService : IBankService
    {
        public async Task<Bank> GetBank()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    
                    HttpResponseMessage Res = await client.GetAsync(APIEndpoints.Get_All_Banks);
                    if (Res.IsSuccessStatusCode)
                    {
                        var EmpResponse = await Res.Content.ReadAsStringAsync();
                         return JsonConvert.DeserializeObject<Bank>(EmpResponse);

                    }
                    throw new ArgumentException(Res.StatusCode.ToString());
                    //return new Bank { ResponseCode = Res.StatusCode.ToString() };

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
