using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;

namespace ProShapeAPI.Models
{
    public class ProShapeAPIContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                    => optionsBuilder.UseNpgsql("Host=(localdb);Port=5432;Database=Golf;Trusted_Connection=True;ConnectRetryCount=0");

        DbSet<ProShapeAPI.Models.Club> Clubs { get; set; }
        DbSet<ProShapeAPI.Models.IntendedShape> IntendedShapes { get; set; }
        DbSet<ProShapeAPI.Models.ActualPower> ActualPowers { get; set; }
        DbSet<ProShapeAPI.Models.ActualShape> ActualShapes { get; set; }
        DbSet<ProShapeAPI.Models.ActualTrajectory> ActualTrajectorys { get; set; }
        DbSet<ProShapeAPI.Models.ChipContact> ChipContacts { get; set; }
        DbSet<ProShapeAPI.Models.ConcentrationQuality> ConcentrationQualitys { get; set; }
        DbSet<ProShapeAPI.Models.Direction> Directions { get; set; }
        DbSet<ProShapeAPI.Models.IntendedPower> IntendedPowers { get; set; }
        DbSet<ProShapeAPI.Models.IntendedTrajectory> IntendedTrajectorys { get; set; }
        DbSet<ProShapeAPI.Models.Lie> Lies { get; set; }
        DbSet<ProShapeAPI.Models.Line> Lines { get; set; }
        DbSet<ProShapeAPI.Models.Outcome> Outcomes { get; set; }
        DbSet<ProShapeAPI.Models.Positional> Positionals { get; set; }
        DbSet<ProShapeAPI.Models.PuttDirection> PuttDirections { get; set; }
        DbSet<ProShapeAPI.Models.PuttDistance> PuttDistances { get; set; }
        DbSet<ProShapeAPI.Models.PuttOutcome> PuttOutcomes { get; set; }
        DbSet<ProShapeAPI.Models.ShortGameOutcome> ShortGameOutcomes { get; set; }
        DbSet<ProShapeAPI.Models.ShortGameShots> ShortGameShotss { get; set; }
        DbSet<ProShapeAPI.Models.ShortGameTrajectories> ShortGameTrajectoriess { get; set; }
        DbSet<ProShapeAPI.Models.ShotType> ShotTypes { get; set; }
        DbSet<ProShapeAPI.Models.Stance> Stances { get; set; }
        DbSet<ProShapeAPI.Models.Strike> Strikes { get; set; }
        DbSet<ProShapeAPI.Models.TeeShotResult> TeeShotResults { get; set; }
        DbSet<ProShapeAPI.Models.Weight> Weights { get; set; }
        DbSet<ProShapeAPI.Models.Wind> Winds { get; set; }

        DbSet<ProShapeAPI.Models.User> Users { get; set; }
        DbSet<ProShapeAPI.Models.Session> Sessions { get; set; }
        DbSet<ProShapeAPI.Models.TeeShots> SessionTeeShots { get; set; }
        DbSet<ProShapeAPI.Models.ApproachShots> SessionApproachShots{ get; set; }
        DbSet<ProShapeAPI.Models.SGShots> SessionShortGameShots{ get; set; }
        DbSet<ProShapeAPI.Models.PuttShots> SessionPuttShots { get; set; }

    }
}
