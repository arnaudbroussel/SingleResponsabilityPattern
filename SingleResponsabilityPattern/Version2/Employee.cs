namespace SingleResponsabilityPattern.Version2 {
    public class Employee {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public override string ToString() {
            return FirstName + " " + LastName + " " + Email;
        }
    }
}
