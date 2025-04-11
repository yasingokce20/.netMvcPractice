namespace BtkAkademi.Models
{
    public static class Repository
    {
        private static List<Candidate> applications = new();
        public static IEnumerable<Candidate> Applications => applications;  // bu satır interface ile ne iş yapıyor ?

        public static void Add(Candidate candidate)
        {
            applications.Add(candidate);
        }
    }
}
