using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProShapeAPI.Models
{
    public class SGShots
    {
        public int Id { get; set; }
        public int SessionID { get; set; }
        public int ClubId { get; set; }

        public int ConcentrationId { get; set; }
        public int WeightId { get; set; }
        public int ShortGameShotId { get; set; }
        public int ShortGameTrajectoryId { get; set; }
        public int ShotTypeId { get; set; }
        public int ChipContactId { get; set; }
        public int DirectionId { get; set; }
        public int StanceId { get; set; }
        public int LieId { get; set; }
        public int WindId { get; set; }
        public int SGOutcomeID { get; set; }
    }
}