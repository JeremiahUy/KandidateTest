using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Kandidattest.Models;
using Newtonsoft.Json;

namespace Kandidattest.Controllers
{
    public class KandidatWebService
    {
        readonly string candidates = "http://kandidattestapi.oxx.no/api/";
        private readonly string token = "b77a5c561934e089";

        public List<VMcandidates> getCandidates() {
            string uri = candidates + "candidates";
            using (HttpClient httpClient = new HttpClient()) {
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                Task<String> response = httpClient.GetStringAsync(uri);
                return JsonConvert.DeserializeObjectAsync<List<VMcandidates>>(response.Result).Result;

            }

        }

    }
}