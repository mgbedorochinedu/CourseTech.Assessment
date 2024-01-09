namespace CourseTech.API.Services.CalculateScoreService
{
    public class CalculateScoreService : ICalculateScoreService
    {
        public CalculateScoreService()
        {

        }

        public int CalculateScore(int[] numbers)
        {
            int score = 0;

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    score += 1; // Add 1 point for each even number
                }
                else
                {
                    score += 3; // Add 3 points for each odd number
                }

                if (num == 8)
                {
                    score += 5; // Add 5 points for encountering 8
                }
            }

            return score;
        }
    }
}
