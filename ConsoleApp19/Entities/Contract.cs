using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19.Entities
{
    internal class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract() { }

        public Contract(int number, DateTime date, double totalValue, List<Installment> installments)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = installments;
        }
    }
}
