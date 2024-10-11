--creating table 'Patient'
create table [Patient](
[patient_id] int Not null,
[name] nvarchar(max) not null,
[gender] nvarchar(max) not null,
[age] int Not null,
[address] nvarchar(max) not null,
[email] nvarchar(max) not null,
primary key (patient_id));
GO

--creating table 'Doctor'
create table [Doctor](
[doctor_id] int Not null,
[name] nvarchar(max) not null,
[department] nvarchar(max) not null,
[email] nvarchar(max) not null,
[status] nvarchar(max) not null,
primary key (doctor_id));
GO
