namespace ConsoleApp1
{
    public class HourlyEmployee : Employee
    {
        public float Hours { get; set; }

        public decimal HourValue { get; set; }

        public override decimal GetValueToPay()
        {
            return (decimal)Hours * HourValue;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\t Horas................: {$"{Hours:N2}",18}" +
                $"\n\t Valor por Hora ......: {$"{HourValue:c2} ",18} " +
                $"\n\t Valor a Pagar........: {$"{GetValueToPay():C2} ",18}";
        }
    }
}
