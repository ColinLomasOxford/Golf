using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProShapeAPI.Models
{
    public class PuttShots
    {
        public int Id { get; set; }
        public int SessionID { get; set; }
        public int ClubId { get; set; }
        public int ConcentrationQualityId { get; set; }
        public int WeightId { get; set; }
        public int ShotTypeId { get; set; }
        public int WindId { get; set; }
        public int LineId { get; set; }
        public int PuttDistanceId { get; set; }
        public int PuttOutcomeId { get; set; }

    }
}