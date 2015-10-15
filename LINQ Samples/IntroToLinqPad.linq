<Query Kind="Program" />

void Main()
{
	string name = "beans";
	SayHello(name);
}

// Define other methods and classes here
public void SayHello(string name)
{
	string message = "cool " + name;
	message.Dump();
}