﻿using System;

public class user
{
	private string userName { get; set; }
	private string Password { get; set; }

	public user()
	{
		Console.WriteLine("Skriv in ett namn: ")

		string name = Console.ReadLine();
		Console.WriteLine("Skriv in ett lösenord: ");
		string lösenord = Console.ReadLine();

		userName = name;
		Password = lösenord;
	}
	public string Namn()
	{
		return userName;
	}
	public string Lösenord()
	{
		return Password;
	}
}
}
