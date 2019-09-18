namespace SingleResponsabilityPattern.Version1 {
    using System;

    public class EmployeeService {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString() {
            return FirstName + " " + LastName;
        }

        public void EmployeeRegistration(EmployeeService employee) {
            StaticData.Employees.Add(employee);
            Console.WriteLine($"Registration OK for {employee}");
        }
    }
}