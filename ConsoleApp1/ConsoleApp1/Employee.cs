namespace ConsoleApp1
{
    public abstract class Employee : IPay
    { //Son propiedades y no atributos privados, y es porque no necesito hacer ninguna validacion sobre atributos
        //propio de la clase, entonces es mejor hacer propiedades
        public int Id { get; set; }

        public string FirstName { get; set; } 
       

        public string LastName { get; set; }

        public Date BirthDate { get; set; }

        public Date HiringDate { get; set; }

        public bool IsActive { get; set; }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"{Id} - {FirstName} {LastName}, " +
                $"Birth: {BirthDate}, " +
                $"Hiring: {HiringDate}, " +
                $"Is active: {IsActive}";

        }
    }
}
