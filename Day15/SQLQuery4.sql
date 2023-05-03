create table banktb(Accno int, AccHolderName varchar(30),Balance int,RefAccno int)
insert into banktb values(123,'Akhila','3000',34),(456,'Remya','4000',44),(789,'Renju','6000',78),(457,'Raju','7000',78)
select * from banktb; 
select a.Accno as ACNO, a.AccHolderName as[Account Name], a.Balance, a.RefAccno as [RefAcno], r.AccHolderName as [Name of referer]
from banktb a join banktb r
on r.RefAccno = a.Accno;
