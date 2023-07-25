namespace PFM.Models
{
    [Serializable]
    public class CustomException : Exception
    {
        public Problem Problem { get; set; }

        public CustomException(Problem problem)
        {
            Problem = problem;
        }
        
    }
}
