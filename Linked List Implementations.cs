
using System;
using System.Collections.Generic;

class GFG {

	static public void Main()
	{

		LinkedList<String> my_list = new LinkedList<String>();

		my_list.AddLast("Zoya");
		my_list.AddLast("Shilpa");
		my_list.AddLast("Rohit");
		my_list.AddLast("Rohan");
		my_list.AddLast("Juhi");
		my_list.AddLast("Zoya");

		Console.WriteLine("Best students of XYZ university:");

		foreach(string str in my_list)
		{
			Console.WriteLine(str);
		}
	}
}
