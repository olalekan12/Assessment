using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Services
{
    //public class LookupService
    //{
    //    private List<StatesWithLGas> CopyStatesandLgasData()
    //    {
    //        try
    //        {
    //            var folderDetails = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot\\{"StatesWithLGAs\\StatesWithLgas.json"}");
    //            var JSON = System.IO.File.ReadAllText(folderDetails);
    //            var jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<StatesWithLGas>>(JSON);
    //            return jsonObj;
    //        }
    //        catch (Exception e)
    //        {
    //            _ = e.Message;
    //            throw;
    //        }
    //    }
    //    public List<string> States()
    //    {
    //        try
    //        {
    //            var jsonObj = CopyStatesandLgasData();
    //            List<string> states = new();
    //            foreach (var item in jsonObj)
    //            {
    //                states.Add(item.state);
    //            }
    //            return states;
    //        }
    //        catch (Exception e)
    //        {
    //            _ = e.Message;
    //            throw;
    //        }
    //    }
    //    public List<string> LgaByState(string stateName)
    //    {

    //        if (string.IsNullOrWhiteSpace(stateName))
    //        {
    //            throw new ArgumentException("State Name is Required");
    //        }
    //        try
    //        {
    //            var jsonObj = CopyStatesandLgasData().Where(s => s.state.Trim().ToLowerInvariant() == stateName.Trim().ToLowerInvariant()).ToList();
    //            List<string> lgas = new();
    //            foreach (var item in jsonObj)
    //            {
    //                lgas = item.lgas;

    //            }
    //            return lgas;


    //        }
    //}

    //}
}
