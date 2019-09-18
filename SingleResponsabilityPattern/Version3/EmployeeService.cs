using SingleResponsabilityPattern.Version2;
using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsabilityPattern.Version3 {
    public class EmployeeService {
        public void EmployeeRegistration(Employee employee) {
            StaticData.Employees.Add(employee);
            Console.WriteLine($"Registration OK for {employee}");

            EmailService emailService = new EmailService();
            emailService.SendEmail(employee);
        }
    }
}
