<Query Kind="Expression">
  <Connection>
    <ID>f9522ad4-fcde-4c85-a404-6d19e327e600</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//orderby

//default ascending
from food in Items
orderby food.Description
select food

//default descending
from food in Items
orderby food.CurrentPrice descending
select food

//default descending ascending
from food in Items
orderby food.CurrentPrice descending, food.Calories ascending
select food

//default ascending with where clause
//default ascending
from food in Items
where food.MenuCategory.Description.Equals("Entree")
orderby food.Description
select food
