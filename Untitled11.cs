using System;
using System.Collections.Generic;

//C++ TO C# CONVERTER TODO TASK: The following method format was not recognized, possibly due to an unrecognized macro:
code.class Employee
{
	// public members
		// initialize id, name and address member variable
		string id;
		string name;
		string address;


		// Constructor
		Employee(string name, string address)
		{
			// 'this' keyword is used to refer to member variable
			this.name = name;
			this.address = address;
		}


		// Print employee's name and address
		void PrintInfo()
		{
			Console.Write("==== Employee ====\n");
			Console.Write("name : ");
			Console.Write(name);
			Console.Write("\n");
			Console.Write("address : ");
			Console.Write(address);
			Console.Write("\n");
			Console.Write("==================\n");
		}

		// Pure virtual function (i.e it doesnt do anything but acts as a placeholder and its functionality will be written in derived classes as per requirement)
		virtual bool EmployeeStatus() = 0;

}

public class Player : Employee
{
		// declare a static counter variable to use for counting objects and define unique id from that.
		public static int counter;

		// member variables
		public double rating;

		// wagePerMatch is same (i.e 1000) for every object
		public const int wagePerMatch = 1000;

		public int noOfMatches;

		// Constructor, Call Base class constructor with name and address
		public Player(string name, string address, double rating, int noOfMatches) : base(name, address)
		{
			this.rating = rating;
			this.noOfMatches = noOfMatches;

			// generate an id from counter (counter is a 3 digit unique number)
			id = "PL-" + Convert.ToString(counter);

			// increment counter after every object creation
			counter++;

		}

		// If rating is greater than 0.7 and number of matches is atleast 10, return true, else return false
		public bool EmployeeStatus()
		{
			if (rating > 0.7 && noOfMatches >= 10)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		// print all the information about player
		public void PrintInfo()
		{
			Console.Write("==== Player ====\n");
			Console.Write("id : ");
			Console.Write(id);
			Console.Write("\n");
			Console.Write("name : ");
			Console.Write(name);
			Console.Write("\n");
			Console.Write("address : ");
			Console.Write(address);
			Console.Write("\n");
			Console.Write("rating : ");
			Console.Write(rating);
			Console.Write("\n");
			Console.Write("number of matches : ");
			Console.Write(noOfMatches);
			Console.Write("\n");

			// if EmployeeStatus() method returns true, print "Eligible for bonus" otherwise print "Not eligible for bonus"
			if (EmployeeStatus())
			{
				Console.Write("Eligible for bonus\n");
			}
			else
			{
				Console.Write("Not eligible for bonus\n");
			}

			Console.Write("==================\n");
		}
}


public class Manager : Employee
{
		// counter to count number of Manager objects created
		public static int counter;
		public int yearsOfExperience;

		// Constructor
		public Manager(string name, string address, int yearsOfExperience) : base(name, address)
		{
			this.yearsOfExperience = yearsOfExperience;
			id = "M-" + Convert.ToString(counter);
			counter++;
		}

		// if years of experience is greater than 4, return true otherwise return false
		public bool EmployeeStatus()
		{
			if (yearsOfExperience > 4)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		// print all the information about manager
		public void PrintInfo()
		{
			Console.Write("==== Manager ====\n");
			Console.Write("id : ");
			Console.Write(id);
			Console.Write("\n");
			Console.Write("name : ");
			Console.Write(name);
			Console.Write("\n");
			Console.Write("address : ");
			Console.Write(address);
			Console.Write("\n");
			Console.Write("years of experience : ");
			Console.Write(yearsOfExperience);
			Console.Write("\n");

			// if EmployeeStatus() method returns true, print "Eligible for bonus" otherwise print "Not eligible for bonus"
			if (EmployeeStatus())
			{
				Console.Write("Eligible for bonus\n");
			}
			else
			{
				Console.Write("Not eligible for bonus\n");
			}

			Console.Write("==================\n\n");
		}
}

public class EmployeeInformationProvider
{
		// declare two vectors to store players' and managers' objects
		public List<Player> players = new List<Player>();
		public List<Manager> managers = new List<Manager>();

		// get the number of players and number of managers to be stored with Constructor
		public EmployeeInformationProvider(int numPlayers, int numManagers)
		{
			players.Capacity = numPlayers;
			managers.res
