truncate table test
CREATE TABLE TEST (EmpId int, salary decimal,marks int)
insert into TEST VALUES(1,3000,50),(2,2000,100),(3,4000,80)
select * from TEST;
select * from TEST WHERE marks<=50;
select count(*) from TEST; 
