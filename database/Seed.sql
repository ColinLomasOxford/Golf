delete from Club;
insert into Club (Id, Name) values (1, 'Driver');
insert into Club (Id, Name) values (2, '3-wood');
insert into Club (Id, Name) values (3, '5-wood');
insert into Club (Id, Name) values (4, 'Rescue');
insert into Club (Id, Name) values (5, '2-iron');
insert into Club (Id, Name) values (6, '3-iron');
insert into Club (Id, Name) values (7, '4-iron');
insert into Club (Id, Name) values (8, '5-iron');
insert into Club (Id, Name) values (9, '6-iron');
insert into Club (Id, Name) values (10, '7-iron');
insert into Club (Id, Name) values (11, '8-iron');
insert into Club (Id, Name) values (12, '9-iron');
insert into Club (Id, Name) values (13, 'PW');
insert into Club (Id, Name) values (14, 'Gap Wedge');
insert into Club (Id, Name) values (15, 'Sand Wedge');
insert into Club (Id, Name) values (16, 'Lob Wedge');
insert into Club (Id, Name) values (17, 'Putter');

delete from ActualPower;
insert into ActualPower (Id, Name) values (1, 'Normal');
insert into ActualPower (Id, Name) values (2, 'Flat-out');
insert into ActualPower (Id, Name) values (3, 'Three  quarter');
insert into ActualPower (Id, Name) values (4, 'Half');

delete from IntendedShape;
insert into IntendedShape(Id, Name) values (1, 'Straight');
insert into IntendedShape(Id, Name) values (2, 'Draw');
insert into IntendedShape(Id, Name) values (3, 'Fade');

delete from IntendedTrajectory;
insert into IntendedTrajectory (Id, Name) values (1, 'Normal');
insert into IntendedTrajectory (Id, Name) values (2, 'High');
insert into IntendedTrajectory (Id, Name) values (3, 'Low');

delete from IntendedPower;
insert into IntendedPower (Id, Name) values (1, 'Flat-out');
insert into IntendedPower (Id, Name) values (2, 'Normal');
insert into IntendedPower (Id, Name) values (3, 'Three quarter');
insert into IntendedPower (Id, Name) values (4, 'Half');

delete from ActualShape;
insert into ActualShape (Id, Name) values (1, 'Straight');
insert into ActualShape (Id, Name) values (2, 'Draw');
insert into ActualShape (Id, Name) values (3, 'Fade');
insert into ActualShape (Id, Name) values (4, 'Pull');
insert into ActualShape (Id, Name) values (5, 'Hook');
insert into ActualShape (Id, Name) values (6, 'Pull-hook');
insert into ActualShape (Id, Name) values (7, 'Push');
insert into ActualShape (Id, Name) values (8, 'Slice');
insert into ActualShape (Id, Name) values (9, 'Push-slice');

delete from Strike;
insert into Strike (Id, Name) values (1, 'Flushed');
insert into Strike (Id, Name) values (2, 'Low on the Face');
insert into Strike (Id, Name) values (3, 'High on the Face');
insert into Strike (Id, Name) values (4, 'Thin');
insert into Strike (Id, Name) values (5, 'Fat');
insert into Strike (Id, Name) values (6, 'Toe');
insert into Strike (Id, Name) values (7, 'Heel');
insert into Strike (Id, Name) values (8, 'Unmentionable');

delete from ActualTrajectory;
insert into ActualTrajectory (Id, Name) values (1, 'Normal ');
insert into ActualTrajectory (Id, Name) values (2, 'High');
insert into ActualTrajectory (Id, Name) values (3, 'Low');

delete from ConcentrationQuality;
insert into ConcentrationQuality (Id, Name) values (1, 'Good focus: decisive and committed');
insert into ConcentrationQuality (Id, Name) values (2, 'Poor focus: distracted or uncommitted');

delete from Weight;
insert into Weight (Id, Name) values (1, 'Long');
insert into Weight (Id, Name) values (2, 'Slightly long');
insert into Weight (Id, Name) values (3, 'Good weight');
insert into Weight (Id, Name) values (4, 'Slightly short');
insert into Weight (Id, Name) values (5, 'Short');

delete from Line;
insert into Line (Id, Name) values (1, 'High');
insert into Line (Id, Name) values (2, 'On-Line');
insert into Line (Id, Name) values (3, 'Low');

delete from ShortGameShots;
insert into ShortGameShots (Id, Name) values (1, 'Chip');
insert into ShortGameShots (Id, Name) values (2, 'Pitch');
insert into ShortGameShots (Id, Name) values (3, 'Bunker shot');
insert into ShortGameShots (Id, Name) values (4, 'Putt from off the green');

delete from ShortGameTrajectories;
insert into ShortGameTrajectories (Id, Name) values (1, 'Low - Bump and run');
insert into ShortGameTrajectories (Id, Name) values (2, 'Normal/ high spin');
insert into ShortGameTrajectories (Id, Name) values (3, 'Lob shot');
insert into ShortGameTrajectories (Id, Name) values (4, 'N/A');

delete from ShotType;
insert into ShotType (Id, Name) values (1, 'Tee Shot');
insert into ShotType (Id, Name) values (2, 'Approach Shot');
insert into ShotType (Id, Name) values (3, 'Short Game Shot');
insert into ShotType (Id, Name) values (4, 'Putt');

delete from PuttDistance;
insert into PuttDistance (Id, Name) values (1, 'Long');
insert into PuttDistance (Id, Name) values (2, 'Medium');
insert into PuttDistance (Id, Name) values (3, 'Short');

delete from ChipContact;
insert into ChipContact (Id, Name) values (1, 'Good strike');
insert into ChipContact (Id, Name) values (2, 'Thin');
insert into ChipContact (Id, Name) values (3, 'Fat');
insert into ChipContact (Id, Name) values (4, 'High on the Face');
insert into ChipContact (Id, Name) values (5, 'Shank');

delete from Direction;
insert into Direction (Id, Name) values (1, 'Left');
insert into Direction (Id, Name) values (2, 'Slightly left');
insert into Direction (Id, Name) values (3, 'Started on line');
insert into Direction (Id, Name) values (4, 'Slightly right');
insert into Direction (Id, Name) values (5, 'Right');

delete from PuttDirection;
insert into PuttDirection (Id, Name) values (1, 'Straight');
insert into PuttDirection (Id, Name) values (2, 'Pulled');
insert into PuttDirection (Id, Name) values (3, 'Pushed');

delete from Stance;
insert into Stance (Id, Name) values (1, 'On Upslope');
insert into Stance (Id, Name) values (2, 'On Downslope');
insert into Stance (Id, Name) values (3, 'Ball Above Feet');
insert into Stance (Id, Name) values (4, 'Ball Below Feet');

delete from Lie;
insert into Lie (Id, Name) values (1, 'Ball sitting up');
insert into Lie (Id, Name) values (2, 'Good lie');
insert into Lie (Id, Name) values (3, 'Ball sitting down');
insert into Lie (Id, Name) values (4, 'Bare lie');
insert into Lie (Id, Name) values (5, 'Fluffy lie');
insert into Lie (Id, Name) values (6, 'Buried');
insert into Lie (Id, Name) values (7, 'Bunker - Good Lie');
insert into Lie (Id, Name) values (8, 'Bunker - Plugged');
insert into Lie (Id, Name) values (9, 'Bunker - Down Hill');
insert into Lie (Id, Name) values (10, 'Bunker - Upslope');

delete from Wind;
insert into Wind (Id, Name) values (1, 'Into wind');
insert into Wind (Id, Name) values (2, 'Down wind');
insert into Wind (Id, Name) values (3, 'Off the left');
insert into Wind (Id, Name) values (4, 'Off the right');
insert into Wind (Id, Name) values (5, 'Into off the left');
insert into Wind (Id, Name) values (6, 'Into off the right');
insert into Wind (Id, Name) values (7, 'Down off the left');
insert into Wind (Id, Name) values (8, 'Down off the right');
insert into Wind (Id, Name) values (9, 'No wind');
insert into Wind (Id, Name) values (10, 'Light wind');
insert into Wind (Id, Name) values (11, 'Medium wind');
insert into Wind (Id, Name) values (12, 'Strong wind');

delete from Outcome;
insert into Outcome (Id, Name) values (1, 'Long left');
insert into Outcome (Id, Name) values (2, 'Long straight');
insert into Outcome (Id, Name) values (3, 'Long right');
insert into Outcome (Id, Name) values (4, 'Target-high left');
insert into Outcome (Id, Name) values (5, 'Target-high straight');
insert into Outcome (Id, Name) values (6, 'Target-high right');
insert into Outcome (Id, Name) values (7, 'Short left');
insert into Outcome (Id, Name) values (8, 'Short straight');
insert into Outcome (Id, Name) values (9, 'Short right');

delete from TeeShotResult;
insert into TeeShotResult (Id, Name) values (1, 'Miss left');
insert into TeeShotResult (Id, Name) values (2, 'Slightly left');
insert into TeeShotResult (Id, Name) values (3, 'Hit target');
insert into TeeShotResult (Id, Name) values (4, 'Slightly right');
insert into TeeShotResult (Id, Name) values (5, 'Miss right');

delete from PuttOutcome;
insert into PuttOutcome (Id, Name) values (1, 'Holed it');
insert into PuttOutcome (Id, Name) values (2, 'Mis-read it');
insert into PuttOutcome (Id, Name) values (3, 'Good putt - almost dropped');
insert into PuttOutcome (Id, Name) values (4, 'Poor putt');
insert into PuttOutcome (Id, Name) values (5, 'Finished inside 3ft');
insert into PuttOutcome (Id, Name) values (6, 'Finished outside 3ft');

delete from ShortGameOutcome;
insert into ShortGameOutcome (Id, Name) values (1, 'Holed it');
insert into ShortGameOutcome (Id, Name) values (2, 'Inside 3ft');
insert into ShortGameOutcome (Id, Name) values (3, 'Inside 6ft');
insert into ShortGameOutcome (Id, Name) values (4, 'Inside 10ft');
insert into ShortGameOutcome (Id, Name) values (5, 'Outside 10ft');

delete from Positional;
insert into Positional (Id, Name) values (1, 'Lay up');
insert into Positional (Id, Name) values (2, 'Hack out');
insert into Positional (Id, Name) values (3, 'Normal');

delete from PSUsers;
insert into PSUsers (Id, Name) values (1, 'Colin Lomas');

delete from Sessions;
insert into Sessions (Id, UserId, Name, DateTimeCreated) values (1, 1, 'Session 1', '2018-06-01');

delete from teeshots
insert into TeeShots
(  id, SessionID, ClubId, IntendedShapeId, IntendedTradjectoryId, IntendedPowerId, ActualShapeId, StrikeId, ActualTrajectoryId, ActualPowerId, ConcentrationQualityId,
  ShotTypeId, WindId, TeeShotOutCome)
  values (1,1,1,1,1,1,1,1,1,1,1,1,1,1)

delete from rangeshots;
insert into rangeshots
(
  SessionID,  ClubId, IntendedShapeId, ActualShapeId, StrikeId
)
values
(
	1, 3, 2, 2, 3
)

select s3.id as sessionId, s3.name as sessionName,
	c.id as clubId, c.name as ClubName,
	i1.id as IntendedShapeId, i1.name as IntendedShapeName,
	a1.id as ActualShapeId, a1.name as ActualShapeName,
	s1.id as StrikeId, s1.name as StrikeName
from rangeshots t
inner join Sessions s3 on s3.id = t.sessionid
inner join Club c on c.id = t.ClubId
inner join IntendedShape i1 on i1.id = t.IntendedShapeId
inner join ActualShape a1 on a1.id = t.ActualShapeId 
inner join Strike s1 on s1.id = t.StrikeId

select s3.id as sessionId, s3.name as sessionName,
	c.id as clubId, c.name as ClubName,
	i1.id as IntendedShapeId, i1.name as IntendedShapeName,
	i2.id as IntendedTrajectoryId, i2.name as IntendedTrajectoryName,
	i3.id as IntendedPowerId, i3.name as IntendedPowerName,
	a1.id as ActualShapeId, a1.name as ActualShapeName,
	s1.id as StrikeId, s1.name as StrikeName,
	a2.Id as ActualTrajectoryId, a2.name as ActualTrajectoryName,
	a3.Id as ActualPowerId, a3.name as ActualPowerName,
	c1.Id as ConcentrationQualityId, c1.name as ConcentrationQualityName,
	s2.Id as ShotTypeId, s2.name as ShotTypeName,
	w1.Id as WindId, w1.name as WindName,
	t1.Id as TeeShotResultId, t1.name as TeeShotResultName
from teeshots t
inner join Sessions s3 on s3.id = t.sessionid
inner join Club c on c.id = t.ClubId
inner join IntendedShape i1 on i1.id = t.IntendedShapeId
inner join IntendedTrajectory i2 on i2.id = t.IntendedTradjectoryId 
inner join IntendedPower i3 on i3.id = t.IntendedPowerId 
inner join ActualShape a1 on a1.id = t.ActualShapeId 
inner join Strike s1 on s1.id = t.StrikeId
inner join ActualTrajectory a2 on a2.id = t.ActualTrajectoryId 
inner join ActualPower a3 on a3.id = t.ActualPowerId 
inner join ConcentrationQuality c1 on c1.id = t.ConcentrationQualityId 
inner join ShotType s2 on s2.id = t.ShotTypeId
inner join Wind w1 on w1.id = t.WindId
inner join TeeShotResult t1 on t1.id = t.TeeShotOutCome
--select * from users
select row_to_json(t)
from (
   select * from Club
) t


--select * from users u, sessions s where s.userid = u.id