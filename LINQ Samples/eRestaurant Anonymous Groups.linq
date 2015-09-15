<Query Kind="Expression">
  <Connection>
    <ID>f9522ad4-fcde-4c85-a404-6d19e327e600</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//anonymous type
from food in Items
where food.MenuCategory.Description.Equals("Entree") &&	food.Active
orderby food.CurrentPrice descending
select new
	{
		Description = food.Description,
		Price = food.CurrentPrice,
		Cost = food.CurrentCost,
		Profit = food.CurrentPrice - food.CurrentCost
	}