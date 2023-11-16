if not exists (select 1 from Person)
begin
  insert into Person ([Name], [Surname], [Age])
  values ('Linus', 'Edlund', 24);
end

if not exists (select 1 from Contact)
begin
  insert into Contact ([Email], [Phone], [GitHub], [LinkedIn], [PersonId])
  values ('Linus.Edlund2@hotmail.com', '070-9963633', 'https://github.com/LinusEdlund', 'fix late', 1);
end
