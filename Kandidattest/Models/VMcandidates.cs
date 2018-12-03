using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kandidattest.Models
{
    public class VMcandidates
    {
        public int Id { get; set; }
        public string CandidateName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }

    public class VMsnittalder {

        public int snitt21til30 { get; set; }
        public int snitt31til40 { get; set; }
        public int snitt40opp { get; set; }
    }
}