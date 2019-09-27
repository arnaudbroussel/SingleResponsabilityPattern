namespace SingleResponsabilityPattern.Version2 {
    using System;

    public class EmployeeService {
        public void EmployeeRegistration(Employee employee) {
            StaticData.Employees.Add(employee);
            Console.WriteLine($"Registration OK for {employee}");

            this.SendEmail(employee);
        }
        public void SendEmail(Employee employee) {
            Console.WriteLine($"Sended Email to {employee.Email} OK for {employee.FirstName} {employee.LastName}");
        }
    }
}
