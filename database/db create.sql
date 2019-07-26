CREATE TABLE ActualPower
(
  id serial PRIMARY KEY,
  Name character varying(100)
);

CREATE TABLE ActualShape
(
  id serial PRIMARY KEY,
  Name character varying(100)
);

CREATE TABLE ActualTrajectory
(
  id serial PRIMARY KEY,
  Name character varying(100)
);

CREATE TABLE ApproachShots
(
  id serial PRIMARY KEY,
	SessionID integer,
  ClubId integer,
  IntendedShapeId integer,
  IntendedTradjectoryId integer,
  IntendedPowerId integer,
  ActualShapeId integer,
  StrikeId integer,
  ActualTrajectoryId integer,
  ActualPowerId integer,
  ConcentrationQualityId integer,
  StanceId integer,
  ShotTypeId integer,
  LieId integer,
  WindId integer,
  OutcomeId integer,
  PositionId integer
);

CREATE TABLE ChipContact
(
  id serial PRIMARY KEY,
  Name character varying(100)
);

CREATE TABLE Club
(
  id serial PRIMARY KEY,
  Name character varying(100)
);

CREATE TABLE ConcentrationQuality
(
  id serial PRIMARY KEY,
  Name character varying(100)
);

CREATE TABLE Direction
(
  id serial PRIMARY KEY,
  Name character varying(100)
);

CREATE TABLE IntendedPower
(
  id serial PRIMARY KEY,
  Name character varying(100)
);

CREATE TABLE IntendedShape
(
  id serial PRIMARY KEY,
  Name character varying(100)
);

CREATE TABLE IntendedTrajectory
(
  id serial PRIMARY KEY,
  Name character varying(100)
);

CREATE TABLE Lie
(
  id serial PRIMARY KEY,
  Name character varying(100)
);

CREATE TABLE Line
(
  id serial PRIMARY KEY,
  Name character varying(100)
);

CREATE TABLE Outcome
(
  id serial PRIMARY KEY,
  Name character varying(100)
);

CREATE TABLE PuttDirection
(
  id serial PRIMARY KEY,
  Name character varying(100)
);

CREATE TABLE PuttDistance
(
  id serial PRIMARY KEY,
  Name character varying(100)
);
CREATE TABLE PuttOutcome
(
  id serial PRIMARY KEY,
  Name character varying(100)
);
CREATE TABLE Positional
(
  id serial PRIMARY KEY,
  Name character varying(100)
);
CREATE TABLE ShortGameOutcome
(
  id serial PRIMARY KEY,
  Name character varying(100)
);
CREATE TABLE ShortGameShots
(
  id serial PRIMARY KEY,
  Name character varying(100)
);
CREATE TABLE ShortGameTrajectories
(
  id serial PRIMARY KEY,
  Name character varying(100)
);
CREATE TABLE ShotType
(
  id serial PRIMARY KEY,
  Name character varying(100)
);
CREATE TABLE Stance
(
  id serial PRIMARY KEY,
  Name character varying(100)
);
CREATE TABLE Strike
(
  id serial PRIMARY KEY,
  Name character varying(100)
);
CREATE TABLE TeeShotResult
(
  id serial PRIMARY KEY,
  Name character varying(100)
);
CREATE TABLE PSUsers
(
  id serial PRIMARY KEY,
  Name character varying(100)
);
CREATE TABLE Weight
(
  id serial PRIMARY KEY,
  Name character varying(100)
);
CREATE TABLE Wind
(
  id serial PRIMARY KEY,
  Name character varying(100)
);

CREATE TABLE TeeShots
(
  id serial PRIMARY KEY,
  SessionID integer,
  ClubId integer,
  IntendedShapeId integer,
  IntendedTradjectoryId integer,
  IntendedPowerId integer,
  ActualShapeId integer,
  StrikeId integer,
  ActualTrajectoryId integer,
  ActualPowerId integer,
  ConcentrationQualityId integer,
  ShotTypeId integer,
  WindId integer,
  TeeShotOutCome integer
);

CREATE TABLE PuttShots
(
  id serial PRIMARY KEY,
  SessionID integer,
  ClubId integer,
  ConcentrationQualityId integer,
  WeightId integer,
  ShotTypeId integer,
  WindId integer,
  LineId integer,
  PuttDistanceId integer,
  PuttOutComeId integer
);

CREATE TABLE Sessions
(
  id serial PRIMARY KEY,
  userid integer,
  Name character varying(100),
  DateTimeCreated date
);

CREATE TABLE SGShots
(
  id serial PRIMARY KEY,
  SessionID integer,
  ClubId integer,
  ConcentrationQualityId integer,
  ShotTypeId integer,
  WeightId integer,
  ShortGameShotId integer,
  ShortGameTrajectoryId integer,
  ChipContactId integer,
  DirectionId integer,
  StanceID integer,
  LieID integer,
  WindId integer,
  SGOutCome integer
)

CREATE TABLE RangeShots
(
  id serial PRIMARY KEY,
	SessionID integer,
  ClubId integer,
  IntendedShapeId integer,
  ActualShapeId integer,
  StrikeId integer
);
