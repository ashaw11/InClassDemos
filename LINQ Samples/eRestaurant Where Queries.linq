<Query Kind="Expression">
  <Connection>
    <ID>f9522ad4-fcde-4c85-a404-6d19e327e600</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//simple where clause

//list all tables that hold more than 3 ppl
from row in Tables
where row.Capacity > 3
select row

//list all items with more than 500 calories and selling for more than $10.00
from food in Items
where food.Calories > 500 && food.CurrentPrice > 10.00m
select food

//list all items with more than 500 calories and are entrees on the menu.
//HINT: The navigational properties of the database and LINQPand knowledge
from food in Items
where food.Calories > 500 && 
	food.MenuCategory.Description.Equals("Entree")
select food
