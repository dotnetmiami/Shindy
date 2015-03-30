
/* 
 * TABLE: Event 
 */

CREATE TABLE Event(
    Event_ID             int               IDENTITY(100,1),
    Title                nvarchar(250)     NULL,
    Description          nvarchar(4000)    NULL,
    Start_Date           datetime2(0)      NOT NULL,
    End_Date             datetime2(0)      NULL,
    Location_ID          int               NULL,
    Registration_URI     varchar(2000)     NULL,
    Created_Date         datetime2(7)      DEFAULT SYSDATETIME() NULL,
    Created_User         nvarchar(50)      NULL,
    Last_Updated_Date    datetime2(7)      DEFAULT SYSDATETIME() NOT NULL,
    Last_Updated_User    nvarchar(50)      NULL,
    CONSTRAINT pk_Event__Event_ID PRIMARY KEY CLUSTERED (Event_ID)
)
go



IF OBJECT_ID('Event') IS NOT NULL
    PRINT '<<< CREATED TABLE Event >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Event >>>'
go

/* 
 * TABLE: Event_Group 
 */

CREATE TABLE Event_Group(
    Event_Group_ID       int             IDENTITY(100,1),
    Event_ID             int             NOT NULL,
    Group_ID             int             NOT NULL,
    Created_Date         datetime2(7)    DEFAULT SYSDATETIME() NULL,
    Created_User         nvarchar(50)    NULL,
    Last_Updated_Date    datetime2(7)    DEFAULT SYSDATETIME() NOT NULL,
    Last_Updated_User    nvarchar(50)    NULL,
    CONSTRAINT pk_Event_Group__Event_Group_ID PRIMARY KEY CLUSTERED (Event_Group_ID)
)
go



IF OBJECT_ID('Event_Group') IS NOT NULL
    PRINT '<<< CREATED TABLE Event_Group >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Event_Group >>>'
go

/* 
 * TABLE: Event_Person 
 */

CREATE TABLE Event_Person(
    Event_Person_ID      int             IDENTITY(100,1),
    Event_ID             int             NOT NULL,
    Person_ID            int             NOT NULL,
    Created_Date         datetime2(7)    DEFAULT SYSDATETIME() NULL,
    Created_User         nvarchar(50)    NULL,
    Last_Updated_Date    datetime2(7)    DEFAULT SYSDATETIME() NOT NULL,
    Last_Updated_User    nvarchar(50)    NULL,
    CONSTRAINT pk_Event_Person__Event_Persion_ID PRIMARY KEY CLUSTERED (Event_Person_ID)
)
go



IF OBJECT_ID('Event_Person') IS NOT NULL
    PRINT '<<< CREATED TABLE Event_Person >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Event_Person >>>'
go

/* 
 * TABLE: Event_Session 
 */

CREATE TABLE Event_Session(
    Event_Session_ID     int             IDENTITY(100,1),
    Event_ID             int             NOT NULL,
    Session_ID           int             NOT NULL,
    Created_Date         datetime2(7)    DEFAULT SYSDATETIME() NULL,
    Created_User         nvarchar(50)    NULL,
    Last_Updated_Date    datetime2(7)    DEFAULT SYSDATETIME() NOT NULL,
    Last_Updated_User    nvarchar(50)    NULL,
    CONSTRAINT pk_Event_Session__Event_Session_ID PRIMARY KEY CLUSTERED (Event_Session_ID)
)
go



IF OBJECT_ID('Event_Session') IS NOT NULL
    PRINT '<<< CREATED TABLE Event_Session >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Event_Session >>>'
go

/* 
 * TABLE: Event_Sponsor 
 */

CREATE TABLE Event_Sponsor(
    Event_Sponsor_ID     int             IDENTITY(100,1),
    Event_ID             int             NOT NULL,
    Sponsor_ID           int             NOT NULL,
    Created_Date         datetime2(7)    DEFAULT SYSDATETIME() NULL,
    Created_User         nvarchar(50)    NULL,
    Last_Updated_Date    datetime2(7)    DEFAULT SYSDATETIME() NOT NULL,
    Last_Updated_User    nvarchar(50)    NULL,
    CONSTRAINT pk_Event_Sponsor__Event_Sponsor_ID PRIMARY KEY CLUSTERED (Event_Sponsor_ID)
)
go



IF OBJECT_ID('Event_Sponsor') IS NOT NULL
    PRINT '<<< CREATED TABLE Event_Sponsor >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Event_Sponsor >>>'
go

/* 
 * TABLE: Giveaway 
 */

CREATE TABLE Giveaway(
    Giveaway_ID          int               IDENTITY(100,1),
    Giveaway_Name        nvarchar(100)     NOT NULL,
    Description          nvarchar(4000)    NULL,
    Event_ID             int               NULL,
    Sponsor_ID           int               NULL,
    Person_ID            int               NULL,
    Created_Date         datetime2(7)      DEFAULT SYSDATETIME() NULL,
    Created_User         nvarchar(50)      NULL,
    Last_Updated_Date    datetime2(7)      DEFAULT SYSDATETIME() NOT NULL,
    Last_Updated_User    nvarchar(50)      NULL,
    CONSTRAINT pk_Giveaway__Giveaway_ID PRIMARY KEY CLUSTERED (Giveaway_ID)
)
go



IF OBJECT_ID('Giveaway') IS NOT NULL
    PRINT '<<< CREATED TABLE Giveaway >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Giveaway >>>'
go

/* 
 * TABLE: User_Group 
 */

CREATE TABLE User_Group(
    Group_ID             int              IDENTITY(100,1),
    Group_Name           nvarchar(100)    NOT NULL,
    Group_Description    varchar(250)     NULL,
    Created_Date         datetime2(7)     DEFAULT SYSDATETIME() NULL,
    Created_User         nvarchar(50)     NULL,
    Last_Updated_Date    datetime2(7)     DEFAULT SYSDATETIME() NOT NULL,
    Last_Updated_User    nvarchar(50)     NULL,
    CONSTRAINT pk_Group__Group_ID PRIMARY KEY CLUSTERED (Group_ID)
)
go



IF OBJECT_ID('User_Group') IS NOT NULL
    PRINT '<<< CREATED TABLE User_Group >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE User_Group >>>'
go

/* 
 * TABLE: Group_Person 
 */

CREATE TABLE Group_Person(
    Group_Person_ID      int             IDENTITY(100,1),
    Group_ID             int             NOT NULL,
    Person_ID            int             NOT NULL,
    Created_Date         datetime2(7)    DEFAULT SYSDATETIME() NULL,
    Created_User         nvarchar(50)    NULL,
    Last_Updated_Date    datetime2(7)    DEFAULT SYSDATETIME() NOT NULL,
    Last_Updated_User    nvarchar(50)    NULL,
    CONSTRAINT pk_Group_Person__Group_Person_ID PRIMARY KEY CLUSTERED (Group_Person_ID)
)
go



IF OBJECT_ID('Group_Person') IS NOT NULL
    PRINT '<<< CREATED TABLE Group_Person >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Group_Person >>>'
go

/* 
 * TABLE: Location 
 */

CREATE TABLE Location(
    Location_ID          int              IDENTITY(100,1),
    Location_Name        nvarchar(100)    NOT NULL,
    Location_URI         varchar(2000)    NULL,
    Street_1             varchar(75)      NULL,
    Street_2             varchar(75)      NULL,
    City                 varchar(50)      NULL,
    State                varchar(50)      NULL,
    Zip_Code             varchar(10)      NULL,
    Map_URI              varchar(2000)    NULL,
    Latitude             numeric(9, 6)    NULL,
    Longitude            numeric(9, 6)    NULL,
    Created_Date         datetime2(7)     DEFAULT SYSDATETIME() NULL,
    Created_User         nvarchar(50)     NULL,
    Last_Updated_Date    datetime2(7)     DEFAULT SYSDATETIME() NOT NULL,
    Last_Updated_User    nvarchar(50)     NULL,
    CONSTRAINT pk_Location__Location_ID PRIMARY KEY CLUSTERED (Location_ID)
)
go



IF OBJECT_ID('Location') IS NOT NULL
    PRINT '<<< CREATED TABLE Location >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Location >>>'
go

/* 
 * TABLE: Person 
 */

CREATE TABLE Person(
    Person_ID            int               IDENTITY(100,1),
    First_Name           nvarchar(50)      NOT NULL,
    Last_Name            nvarchar(50)      NOT NULL,
    EMail                varchar(320)      NULL,
    Member_URI           varchar(2000)     NULL,
    Twitter_Name         varchar(50)       NULL,
    Linkedin_URI         varchar(2000)     NULL,
    Bio                  nvarchar(4000)    NULL,
    Photo_URI            varchar(2000)     NULL,
    Zip                  varchar(10)       NULL,
    Created_Date         datetime2(7)      DEFAULT SYSDATETIME() NULL,
    Created_User         nvarchar(50)      NULL,
    Last_Updated_Date    datetime2(7)      DEFAULT SYSDATETIME() NOT NULL,
    Last_Updated_User    nvarchar(50)      NULL,
    CONSTRAINT pk_Person__Person_ID PRIMARY KEY CLUSTERED (Person_ID)
)
go



IF OBJECT_ID('Person') IS NOT NULL
    PRINT '<<< CREATED TABLE Person >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Person >>>'
go

/* 
 * TABLE: Session 
 */

CREATE TABLE Session(
    Session_ID           int               IDENTITY(100,1),
    Title                nvarchar(100)     NOT NULL,
    Abstract             nvarchar(4000)    NULL,
    Session_Type_ID      int               NOT NULL,
    Created_Date         datetime2(7)      DEFAULT SYSDATETIME() NULL,
    Created_User         nvarchar(50)      NULL,
    Last_Updated_Date    datetime2(7)      DEFAULT SYSDATETIME() NOT NULL,
    Last_Updated_User    nvarchar(50)      NULL,
    CONSTRAINT pk_Session__Session_ID PRIMARY KEY CLUSTERED (Session_ID)
)
go



IF OBJECT_ID('Session') IS NOT NULL
    PRINT '<<< CREATED TABLE Session >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Session >>>'
go

/* 
 * TABLE: Session_Person 
 */

CREATE TABLE Session_Person(
    Session_Person_ID    int             IDENTITY(100,1),
    Session_ID           int             NOT NULL,
    Person_ID            int             NOT NULL,
    Created_Date         datetime2(7)    DEFAULT SYSDATETIME() NULL,
    Created_User         nvarchar(50)    NULL,
    Last_Updated_Date    datetime2(7)    DEFAULT SYSDATETIME() NOT NULL,
    Last_Updated_User    nvarchar(50)    NULL,
    CONSTRAINT pk_Session_Person__Session_Person_ID PRIMARY KEY CLUSTERED (Session_Person_ID)
)
go



IF OBJECT_ID('Session_Person') IS NOT NULL
    PRINT '<<< CREATED TABLE Session_Person >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Session_Person >>>'
go

/* 
 * TABLE: Session_Type 
 */

CREATE TABLE Session_Type(
    Session_Type_ID      int              IDENTITY(100,1),
    Session_Type_Name    nvarchar(100)    NOT NULL,
    Description          varchar(250)     NULL,
    Created_Date         datetime2(7)     DEFAULT SYSDATETIME() NULL,
    Created_User         nvarchar(50)     NULL,
    Last_Updated_Date    datetime2(7)     DEFAULT SYSDATETIME() NOT NULL,
    Last_Updated_User    nvarchar(50)     NULL,
    CONSTRAINT pk_Session_Type__Session_Type_ID PRIMARY KEY CLUSTERED (Session_Type_ID)
)
go



IF OBJECT_ID('Session_Type') IS NOT NULL
    PRINT '<<< CREATED TABLE Session_Type >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Session_Type >>>'
go

/* 
 * TABLE: Sponsor 
 */

CREATE TABLE Sponsor(
    Sponsor_ID           int              IDENTITY(100,1),
    Sponsor_Name         nvarchar(100)    NOT NULL,
    Sponsor_URI          varchar(2000)    NULL,
    Image_URI            varchar(2000)    NULL,
    Created_Date         datetime2(7)     DEFAULT SYSDATETIME() NULL,
    Created_User         nvarchar(50)     NULL,
    Last_Updated_Date    datetime2(7)     DEFAULT SYSDATETIME() NOT NULL,
    Last_Updated_User    nvarchar(50)     NULL,
    CONSTRAINT pk_Sponsor__Sponsor_ID PRIMARY KEY CLUSTERED (Sponsor_ID)
)
go



IF OBJECT_ID('Sponsor') IS NOT NULL
    PRINT '<<< CREATED TABLE Sponsor >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Sponsor >>>'
go

/* 
 * INDEX: ak_Event_Group__Event_ID_Group_ID 
 */

CREATE UNIQUE INDEX ak_Event_Group__Event_ID_Group_ID ON Event_Group(Event_ID, Group_ID)
go
IF EXISTS (SELECT * FROM sys.indexes WHERE object_id=OBJECT_ID('Event_Group') AND name='ak_Event_Group__Event_ID_Group_ID')
    PRINT '<<< CREATED INDEX Event_Group.ak_Event_Group__Event_ID_Group_ID >>>'
ELSE
    PRINT '<<< FAILED CREATING INDEX Event_Group.ak_Event_Group__Event_ID_Group_ID >>>'
go

/* 
 * INDEX: ak_Event_Person__Event_ID_Person_ID 
 */

CREATE UNIQUE INDEX ak_Event_Person__Event_ID_Person_ID ON Event_Person(Event_ID, Person_ID)
go
IF EXISTS (SELECT * FROM sys.indexes WHERE object_id=OBJECT_ID('Event_Person') AND name='ak_Event_Person__Event_ID_Person_ID')
    PRINT '<<< CREATED INDEX Event_Person.ak_Event_Person__Event_ID_Person_ID >>>'
ELSE
    PRINT '<<< FAILED CREATING INDEX Event_Person.ak_Event_Person__Event_ID_Person_ID >>>'
go

/* 
 * INDEX: ak_Event_Session__Event_ID_Session_ID 
 */

CREATE UNIQUE INDEX ak_Event_Session__Event_ID_Session_ID ON Event_Session(Event_ID, Session_ID)
go
IF EXISTS (SELECT * FROM sys.indexes WHERE object_id=OBJECT_ID('Event_Session') AND name='ak_Event_Session__Event_ID_Session_ID')
    PRINT '<<< CREATED INDEX Event_Session.ak_Event_Session__Event_ID_Session_ID >>>'
ELSE
    PRINT '<<< FAILED CREATING INDEX Event_Session.ak_Event_Session__Event_ID_Session_ID >>>'
go

/* 
 * INDEX: ak_Event_Sponsor__Event_ID_Sponsor_ID 
 */

CREATE UNIQUE INDEX ak_Event_Sponsor__Event_ID_Sponsor_ID ON Event_Sponsor(Event_ID, Sponsor_ID)
go
IF EXISTS (SELECT * FROM sys.indexes WHERE object_id=OBJECT_ID('Event_Sponsor') AND name='ak_Event_Sponsor__Event_ID_Sponsor_ID')
    PRINT '<<< CREATED INDEX Event_Sponsor.ak_Event_Sponsor__Event_ID_Sponsor_ID >>>'
ELSE
    PRINT '<<< FAILED CREATING INDEX Event_Sponsor.ak_Event_Sponsor__Event_ID_Sponsor_ID >>>'
go

/* 
 * INDEX: ak_Group__Group_Name 
 */

CREATE UNIQUE INDEX ak_Group__Group_Name ON User_Group(Group_Name)
go
IF EXISTS (SELECT * FROM sys.indexes WHERE object_id=OBJECT_ID('User_Group') AND name='ak_Group__Group_Name')
    PRINT '<<< CREATED INDEX User_Group.ak_Group__Group_Name >>>'
ELSE
    PRINT '<<< FAILED CREATING INDEX User_Group.ak_Group__Group_Name >>>'
go

/* 
 * INDEX: ak_Group_Person__Group_ID_Person_ID 
 */

CREATE UNIQUE INDEX ak_Group_Person__Group_ID_Person_ID ON Group_Person(Group_ID, Person_ID)
go
IF EXISTS (SELECT * FROM sys.indexes WHERE object_id=OBJECT_ID('Group_Person') AND name='ak_Group_Person__Group_ID_Person_ID')
    PRINT '<<< CREATED INDEX Group_Person.ak_Group_Person__Group_ID_Person_ID >>>'
ELSE
    PRINT '<<< FAILED CREATING INDEX Group_Person.ak_Group_Person__Group_ID_Person_ID >>>'
go

/* 
 * INDEX: ak_Session_Person__Session_ID_Person_ID 
 */

CREATE UNIQUE INDEX ak_Session_Person__Session_ID_Person_ID ON Session_Person(Session_ID, Person_ID)
go
IF EXISTS (SELECT * FROM sys.indexes WHERE object_id=OBJECT_ID('Session_Person') AND name='ak_Session_Person__Session_ID_Person_ID')
    PRINT '<<< CREATED INDEX Session_Person.ak_Session_Person__Session_ID_Person_ID >>>'
ELSE
    PRINT '<<< FAILED CREATING INDEX Session_Person.ak_Session_Person__Session_ID_Person_ID >>>'
go

/* 
 * INDEX: ak_Session_Type__Session_Type_Name 
 */

CREATE UNIQUE INDEX ak_Session_Type__Session_Type_Name ON Session_Type(Session_Type_Name)
go
IF EXISTS (SELECT * FROM sys.indexes WHERE object_id=OBJECT_ID('Session_Type') AND name='ak_Session_Type__Session_Type_Name')
    PRINT '<<< CREATED INDEX Session_Type.ak_Session_Type__Session_Type_Name >>>'
ELSE
    PRINT '<<< FAILED CREATING INDEX Session_Type.ak_Session_Type__Session_Type_Name >>>'
go

/* 
 * INDEX: ak_Sponsor__Sponsor_Name 
 */

CREATE UNIQUE INDEX ak_Sponsor__Sponsor_Name ON Sponsor(Sponsor_Name)
go
IF EXISTS (SELECT * FROM sys.indexes WHERE object_id=OBJECT_ID('Sponsor') AND name='ak_Sponsor__Sponsor_Name')
    PRINT '<<< CREATED INDEX Sponsor.ak_Sponsor__Sponsor_Name >>>'
ELSE
    PRINT '<<< FAILED CREATING INDEX Sponsor.ak_Sponsor__Sponsor_Name >>>'
go

/* 
 * TABLE: Event 
 */

ALTER TABLE Event ADD CONSTRAINT fk_Event_Location_ID__Location_Location_ID 
    FOREIGN KEY (Location_ID)
    REFERENCES Location(Location_ID)
go


/* 
 * TABLE: Event_Group 
 */

ALTER TABLE Event_Group ADD CONSTRAINT fk_Event_Group_Group_ID__User_Group_Group_ID 
    FOREIGN KEY (Group_ID)
    REFERENCES [User_Group](Group_ID)
go

ALTER TABLE Event_Group ADD CONSTRAINT fk_Event_Group_Group_ID__Event_Event_ID 
    FOREIGN KEY (Event_ID)
    REFERENCES Event(Event_ID)
go


/* 
 * TABLE: Event_Person 
 */

ALTER TABLE Event_Person ADD CONSTRAINT fk_Event_Person_Person_ID__Person_Person_ID 
    FOREIGN KEY (Person_ID)
    REFERENCES Person(Person_ID)
go

ALTER TABLE Event_Person ADD CONSTRAINT fk_Event_Person_Event_ID_Person_Person_ID 
    FOREIGN KEY (Event_ID)
    REFERENCES Event(Event_ID)
go


/* 
 * TABLE: Event_Session 
 */

ALTER TABLE Event_Session ADD CONSTRAINT fk_Event_Session_Session_ID__Session_Session_ID 
    FOREIGN KEY (Session_ID)
    REFERENCES Session(Session_ID)
go

ALTER TABLE Event_Session ADD CONSTRAINT fk_Event_Session_Event_ID__Event_Event_ID 
    FOREIGN KEY (Event_ID)
    REFERENCES Event(Event_ID)
go


/* 
 * TABLE: Event_Sponsor 
 */

ALTER TABLE Event_Sponsor ADD CONSTRAINT fk_Event_Sponsor_Sponsor_ID__Sponsor_Sponsor_ID 
    FOREIGN KEY (Sponsor_ID)
    REFERENCES Sponsor(Sponsor_ID)
go

ALTER TABLE Event_Sponsor ADD CONSTRAINT fk_Event_Sponsor_Event_ID__Event_Event_ID 
    FOREIGN KEY (Event_ID)
    REFERENCES Event(Event_ID)
go


/* 
 * TABLE: Giveaway 
 */

ALTER TABLE Giveaway ADD CONSTRAINT fk_Giveaway_Sponsor_ID__Sponsor_Sponsor_ID 
    FOREIGN KEY (Sponsor_ID)
    REFERENCES Sponsor(Sponsor_ID)
go

ALTER TABLE Giveaway ADD CONSTRAINT fk_Giveaway_Person_ID__Person_ID 
    FOREIGN KEY (Person_ID)
    REFERENCES Person(Person_ID)
go

ALTER TABLE Giveaway ADD CONSTRAINT fk_Giveaway_Event_ID__Event_Event_ID 
    FOREIGN KEY (Event_ID)
    REFERENCES Event(Event_ID)
go


/* 
 * TABLE: Group_Person 
 */

ALTER TABLE Group_Person ADD CONSTRAINT fk_Group_Person_Person_ID__Person_Person_ID 
    FOREIGN KEY (Person_ID)
    REFERENCES Person(Person_ID)
go

ALTER TABLE Group_Person ADD CONSTRAINT fk_Group_Person_Group_ID__User_Group_Group_ID 
    FOREIGN KEY (Group_ID)
    REFERENCES User_Group(Group_ID)
go


/* 
 * TABLE: Session 
 */

ALTER TABLE Session ADD CONSTRAINT fk_SessionSession_Type_ID__Session_Type_Session_Type_ID 
    FOREIGN KEY (Session_Type_ID)
    REFERENCES Session_Type(Session_Type_ID)
go


/* 
 * TABLE: Session_Person 
 */

ALTER TABLE Session_Person ADD CONSTRAINT fk_Session_Person_Person_ID__Person_Person_ID 
    FOREIGN KEY (Person_ID)
    REFERENCES Person(Person_ID)
go

ALTER TABLE Session_Person ADD CONSTRAINT fk_Session_Person_Session_ID__Session_Session_ID 
    FOREIGN KEY (Session_ID)
    REFERENCES Session(Session_ID)
go


