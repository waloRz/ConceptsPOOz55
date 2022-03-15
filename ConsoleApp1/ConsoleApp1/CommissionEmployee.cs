using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CommissionEmployee : Employee
    {
        public float CommissionPercentaje { get; set; }

        public decimal Sales { get; set; }

        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPercentaje;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\t Commission percentaje: {$"{CommissionPercentaje:P2}", 18}" +
                $"\n\t Sales................: {$"{Sales:c2} ", 18} " +
                $"\n\t Value to pay ........: {$"{GetValueToPay():C2} ", 18}";
        }
    }
}
