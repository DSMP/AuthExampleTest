using AuthExample.Db;
using AuthExampleLibrary.Model.Entities;
using AuthExampleLibrary.Model.Models.AnonymousUsers;
using AuthExampleLibrary.Service.IServices;
using AuthExampleLibrary.Services;
using System;

namespace AuthExample
{
    class Program
    {
        private readonly AuthExampleContext _dbContext;
        ILogin _authenticateService;
        public Program()
        {
            _dbContext = new AuthExampleContext();
            _authenticateService = new AuthenticateService(_dbContext);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program program = new Program();
            program.MakeLoginLoop();
        }

        private void MakeLoginLoop()
        {
            try
            {
                while (true)
                {
                    _TryLogin();
                }
            }
            finally
            {
                _dbContext.Dispose();
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
