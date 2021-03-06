﻿#region Read me please

	// Application Name: MyApp
	// Created by DotNET Nuclear C# Compiler
	// Date Created: Walking Armageddon	// Author: RIT

#endregion

#region Using directives

	using System;
	using System.IO;
	using System.Reflection;
#endregion

#region Assembly attributes

	[assembly: AssemblyTitle("MyApp")]
	[assembly: AssemblyProduct("MyApp")]
	[assembly: AssemblyVersion("1.0.*")]
	[assembly: AssemblyDescription("Created by DotNET Nuclear C# Compiler")]
	[assembly: AssemblyCompany("DotNET Nuclear C# Compiler")]
	[assembly: AssemblyCopyright("Copyright © 2018")]

#endregion

namespace MyApp
{
	/// <summary>
	/// Summary description for MyAppClass.
	/// </summary>
	class MyAppClass
	{
		 static void Main(string[] args)
        {
            if(File.Exists("test.txt"))
            {
                string content = File.ReadAllText("test.txt");
                Console.WriteLine("Current content of file:");
                Console.WriteLine(content);
            }
            Console.WriteLine("Please enter new content for the file:");
            string newContent = Console.ReadLine();
            File.WriteAllText("test.txt", newContent);
        }
	}
}