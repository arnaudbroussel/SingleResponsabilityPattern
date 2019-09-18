namespace SingleResponsabilityPattern.Version2 {
    using System.Collections.Generic;

    public class StaticData {
        public static List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
