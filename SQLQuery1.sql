use Newdatabase

create table test1
(
column1 varchar (20),
Age int,
Dept varchar (50)

)



create table test2
(
emp_id int,
first_name varchar(20),
last_name varchar(30)

)


select * from test2

insert into test2
select 101,'Prasun','Mukherjee' union all
select 102,'Ritwik','Gupta' union all
select 103,'Sakshi','Khare'
