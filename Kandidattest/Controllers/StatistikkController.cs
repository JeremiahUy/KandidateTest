using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kandidattest.Models;

namespace Kandidattest.Controllers
{
    public class StatistikkController : Controller
    {
        private KandidatWebService candidates = new KandidatWebService();
        // GET: Statistikk
        public ActionResult statiskkAlder()
        {
            List<VMcandidates> candidate = candidates.getCandidates();
            return View(Gjennomsnitt(candidate));
        }


        public VMsnittalder Gjennomsnitt(List<VMcandidates> candidates)
        {
            int a = 0; int b = 0; int c = 0;
            int totala = 0; int totalb = 0; int totalc = 0;

            foreach (var item in candidates)
            {
                if (item.Age <= 30 && item.Age >= 21)
                {
                    a += item.Age;
                    totala += 1;
                }
                else if (item.Age <= 40 && item.Age >= 31)
                {
                    b += item.Age;
                    totalb += 1;
                }
                else if (item.Age >= 41)
                {
                    c += item.Age;
                    totalc += 1;
                }

            }
            var resultat = new VMsnittalder() {

                snitt21til30 = a / totala,
                snitt31til40 = b / totalb,
                snitt40opp = c /totalc
            };            
            return resultat;
        }
    }
}