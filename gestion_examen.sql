use master
go 

if exists(select *  from sysdatabases where name = 'gestion_examen')
begin
  drop database gestion_examen
end
go

create database gestion_examen
go

use gestion_examen
go

if object_id('exams') is null
begin
  create table exams(
    id int identity primary key not null,
    num_questions int not null,
    date date not null
  )
end

if object_id('students') is null
begin
  create table students(
    id int identity primary key not null,
    name varchar(50) not null,
    groups int not null
  )
end

if object_id('practices') is null
begin
  create table practices(
    id int identity primary key not null,
    title varchar(50) not null,
    difficulty varchar(20) not null
  )
end

if object_id('teachers') is null
begin
  create table teachers(
    id int identity primary key not null,
    name varchar(50) not null
  )
end

-- ----------------------- has ---------------------------

if object_id('exams_students') is null
begin
  create table exams_students(
    exams_id int not null,
    students_id int not null,
    note int not null,

    constraint pk_exams_students primary key clustered (exams_id, students_id),
    constraint fk_exams_students_exams foreign key (exams_id) references exams(id),
    constraint fk_exams_students_students foreign key (students_id) references students(id)
  )
end

if object_id('students_practices') is null
begin
  create table students_practices(
    students_id int not null,
    practices_id int not null,
    note int not null,
    date date not null

    constraint pk_students_practices primary key clustered (practices_id, students_id),
    constraint fk_students_practices_students foreign key (students_id) references students(id),
    constraint fk_students_practices_practices foreign key (practices_id) references practices(id)
  )
end

if object_id('practices_teachers') is null
begin
  create table practices_teachers(
    practices_id int not null,
    teachers_id int not null,
    date date not null

    constraint pk_practices_teachers primary key clustered (practices_id, teachers_id),
    constraint fk_practices_teachers_practices foreign key (practices_id) references practices(id),
    constraint fk_practices_teachers_teachers foreign key (teachers_id) references teachers(id)
  )
end
