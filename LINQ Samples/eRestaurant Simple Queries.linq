<Query Kind="Statements">
  <Connection>
    <ID>f9522ad4-fcde-4c85-a404-6d19e327e600</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

/*Step 1) Connect to the desired db
Click on "Add connection"
Take defaults, press "Next"
Change server to ".", select existing db from drop down list
optionally press "Test Connection"
press "OK"
Remember to check the connection drop down list to see which db is the active connection

Result should show db tables in connection object area
Expanding a table will reveal the table attributes and any relationships*/

//View Waiter data
Waiters

//query query to also view Waiter data
from item in Waiters
select item

//method syntax to view Waiter data
Waiters.Select (item => item)

//alter the query syntax into a c# statement
var results = from item in Waiters
				select item;
results.Dump();

//once the query is created and tested, you will be able to transfer the query with minor modifications into your BLL methods
public List<pocoObject> SomeBLLMethodName()
{
	//content to your DAL
	//do your query
	var results = from item in Waiters
				select item;
	return results.Dump();
}