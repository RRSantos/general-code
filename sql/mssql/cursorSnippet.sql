declare
	@myVariable int

declare cursor_name cursor for
	select [column]
	from [table]

open cursor_name
fetch next from cursor_name
	into @myVariable

while @@fetch_status = 0
begin
	/*Do something*/
	fetch next from cursor_name
		into @myVariable
end

close cursor_name
deallocate cursor_name