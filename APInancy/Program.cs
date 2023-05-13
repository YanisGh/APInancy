﻿using Nancy.Hosting.Self;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace APInancy
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString = "server=localhost;user=root;password=;database=abcsignapi";

            MySqlConnection conn = new MySqlConnection(connString);

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                Console.WriteLine("Connected to the database!");
            }
            else
            {
                Console.WriteLine("Not connected to the database.");
            }

            using (var host = new NancyHost(new Uri("http://localhost:8080")))
            {
                host.Start();

                Console.WriteLine("NancyFX Stand alone test application.");
                Console.WriteLine("Press enter to exit the application");
                Console.ReadLine();
            }
        }
    }
}