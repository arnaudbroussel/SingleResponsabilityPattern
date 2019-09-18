using SingleResponsabilityPattern.Version2;
using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsabilityPattern.Version3 {
    public class EmailService {
        public void SendEmail(Employee employee) {
            Console.WriteLine($"Sended Email to {employee.Email} OK for {employee.FirstName} {employee.LastName}");
        }
    }
}
