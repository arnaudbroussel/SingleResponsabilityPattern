namespace SingleResponsabilityPattern.Version1 {
    using System.Collections.Generic;

    public class StaticData {
        public static List<EmployeeService> Employees { get; set; } = new List<EmployeeService>();
    }
}
