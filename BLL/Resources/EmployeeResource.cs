namespace carpoolapp.BLL.Resources
{
    public class EmployeeResource
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName {
            get {
                return LastName + ", " + FirstName;
            }
        }
        public bool IsDriver { get; set; }
    }
}