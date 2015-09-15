<Query Kind="Expression">
  <Connection>
    <ID>f9522ad4-fcde-4c85-a404-6d19e327e600</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//grouping
from food in Items
group food by food.MenuCategory.Description

//requires the creation of an anonymous type
from food in Items
group food by new {food.MenuCategory.Description, food.CurrentPrice}