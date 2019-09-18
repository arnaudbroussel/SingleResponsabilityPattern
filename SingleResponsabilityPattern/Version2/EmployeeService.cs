namespace SingleResponsabilityPattern.Version2 {
    using System;

    public class EmployeeService {
        public void EmployeeRegistration(Employee employee) {
            StaticData.Employees.Add(employee);
            Console.WriteLine($"Registration OK for {employee}");
        }

    }
}
