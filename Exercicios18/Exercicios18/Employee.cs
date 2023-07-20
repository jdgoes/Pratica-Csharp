namespace Exercicios18
{
    class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set;}
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary (double percentage) 
        {
            Salary += Salary * percentage / 100.0;
        }


        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Salary: $ {Salary:F2}";
        }

    }
}
