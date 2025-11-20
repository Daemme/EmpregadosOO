using System.Globalization;
using EmpregadosOO.Entities;

namespace EmpregadosOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do departamento: ");
            string departmentName = Console.ReadLine();
            Console.Write("Dia do pagamento: ");
            int payday = int.Parse(Console.ReadLine());
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Telefone: ");
            string phone = Console.ReadLine();

            Address address = new Address(email, phone);
            Department department = new Department(departmentName, payday, address);

            Console.Write("Quantos funcionários tem o departamento? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do funcionario{1}");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salário: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                Employee employee = new Employee(name, salary);
                department.Employees.Add(employee);
            }

            Console.WriteLine();
            Console.WriteLine("FOLHA DE PAGAMENTO");
            ShowReport(department);

        }

        static void ShowReport(Department department)
        {
            Console.WriteLine($"Departamento Vendas = R${department.PayRoll().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Pagamento realizado no dia {department.PayDay}");
            Console.WriteLine("Funcionários: ");
            foreach (Employee employee in department.Employees)
            {
                Console.WriteLine(employee.Name);
            }
            Console.WriteLine("Para dúvidas favor entrar em contato: " + department.Address.Email);
        }
    }
}