create trigger empinstrg on Person
after insert
as
select 'Row Created';