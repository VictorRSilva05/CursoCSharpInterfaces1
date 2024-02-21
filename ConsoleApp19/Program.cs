using ConsoleApp19.Entities;
using ConsoleApp19.Services;
using System.Diagnostics.Contracts;
using System.Globalization;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data:");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date: (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            Contracts contracts = new Contracts(number, date, value);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contracts, installments);

            Console.WriteLine("Installments:");
            foreach (Installment installment in contracts.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}