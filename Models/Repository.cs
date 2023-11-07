namespace BtkAkademi.Models
{
    public  static class Repository
    {
        private static List<Candidate> aplications=new();
        public static IEnumerable<Candidate> Aplications=>aplications;
        public  static void Add(Candidate candidate)
        {
            aplications.Add(candidate);
        }
    }
}