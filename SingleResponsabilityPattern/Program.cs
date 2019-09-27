namespace SingleResponsabilityPattern {
    using System;

    class Program {
        static void Main(string[] args) {
            ConsoleKeyInfo cki;
            do {
                DisplayMenu();
                cki = Console.ReadKey(false);
                Console.WriteLine();
                switch (cki.KeyChar.ToString()) {
                    case "1":
                        Version1();
                        break;
                    case "2":
                        Version2();
                        break;
                    case "3":
                        Version3();
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);
        }

        static public void DisplayMenu() {
            Console.WriteLine();
            Console.WriteLine("SINGLE RESPONSABILITY PATTERN");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            Console.WriteLine("1. Iteration 1");
            Console.WriteLine("2. Iteration 2");
            Console.WriteLine("3. Iteration 3");
            Console.WriteLine("(esc to exit)");
            Console.WriteLine();
        }

        static void Version1() {
            SingleResponsabilityPattern.Version1.EmployeeService employeeService = new SingleResponsabilityPattern.Version1.EmployeeService {
                FirstName = "John",
                LastName = "Doe"
            };
            employeeService.EmployeeRegistration(employeeService);
        }

        static void Version2() {
            SingleResponsabilityPattern.Version2.Employee employee = new SingleResponsabilityPattern.Version2.Employee {
                FirstName = "John",
                LastName = "Deo",
                Email = "jdeo@sample.com"
            };
            SingleResponsabilityPattern.Version2.EmployeeService employeeService = new SingleResponsabilityPattern.Version2.EmployeeService();
            employeeService.EmployeeRegistration(employee);
        }

        static void Version3() {
            SingleResponsabilityPattern.Version2.Employee employee = new SingleResponsabilityPattern.Version2.Employee {
                FirstName = "John",
                LastName = "Deo",
                Email = "jdeo@sample.com"
            };
            SingleResponsabilityPattern.Version3.EmployeeService employeeService = new SingleResponsabilityPattern.Version3.EmployeeService();
            employeeService.EmployeeRegistration(employee);
        }

    }
}
