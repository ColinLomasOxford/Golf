using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProShapeAPI.Models
{
    public class TeeShots
    {
        public int Id { get; set; }
        public int SessionID { get; set; }
        public int ClubId { get; set; }
        public int IntendedShapeId { get; set; }
        public int IntendedTradjectoryId { get; set; }
        public int IntendedPowerId { get; set; }
        public int ActualShapeId { get; set; }
        public int StrikeId { get; set; }
        public int ActualTrajectoryId { get; set; }
        public int ActualPowerId { get; set; }
        public int ConcentrationQualityId { get; set; }
        public int ShotTypeId { get; set; }
        public int WindId { get; set; }
        public int TeeShotOutcome { get; set; }
    }
}