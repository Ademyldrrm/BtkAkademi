namespace  BtkAkademi.Models
{
    public  class Candidate
    {
        public string? Email { get; set; } = string.Empty;
        public string? FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; }= string.Empty;
        public string? FullName =>$"{FirstName} {LastName?.ToUpper()}";
        public string? SelectedCourse { get; set; }= string.Empty;
        public DateTime ApplyAt { get; set; }
        public int? Age { get; set; } 

        public Candidate()
        {
            ApplyAt=DateTime.Now;
        }
    }
}