using System;

namespace BowlingScoreCarculator
{
    class Program
    {
        private static int[] scores;

        static void Main(string[] args)
        {
            var sum = 0;

            Console.WriteLine("10프레임동안 쓰러트린 볼링핀의 개수를 하나씩 입력해주세요.");
            for(int i = 0; i < 10; i++)
            {
                ScoreIn(i);
            }

        }

        private static int Spare(String score)
        {
            var sum = 0;

            return sum;
        }

        private static int Strike(String score)
        {
            var sum = 0;

            return sum;
        }

        private static void ScoreIn(int array)
        {
            scores[array] = Console.Read();
        }
    }
}
