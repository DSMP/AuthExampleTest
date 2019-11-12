﻿using AuthExample.Db;
using AuthExampleLibrary.Model.Models.AnonymousUsers;
using AuthExampleLibrary.Service.IServices;
using AuthExampleLibrary.Services;
using System;

namespace AuthExample
{
    class Program
    {
        ILogin _authenticateService;
        public Program()
        {
            _authenticateService = new AuthenticateService();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program program = new Program();
            while (true)
            {
                program._TryLogin();
            }
        }

        private void _TryLogin()
        {
            Console.Write("Type user: ");
            var userName = Console.ReadLine();

            Console.Write("Type password: ");
            var password = Console.ReadLine();

            var resultUser = _authenticateService.Authenticate(new AnonymousUser(userName, password));
            if (resultUser != null)
            {
                Console.WriteLine("You are logged");
            }
            else
            {
                Console.WriteLine("Username or password are invalid");
            }
        }
    }
}