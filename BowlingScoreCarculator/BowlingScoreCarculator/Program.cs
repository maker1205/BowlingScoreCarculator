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

            Console.WriteLine("계산중입니다......");

            for (int i = 0; i < 9; i++)
            {
                if (scores[i] == 10)
                {
                    Strike(scores[i + 1], scores[i + 2]);
                }
                else
                {

                }
            }
        }

        private static int Spare(int score)
        {
            var sum = 0;

            return sum;
        }

        private static int Strike(int score1,int score2)
        {
            var eachFrameSum = 0;
            var baseScore = 10;
            eachFrameSum = baseScore + score1 + score2;
            return eachFrameSum;
        }

        private static void ScoreIn(int array)
        {
            scores[array] = Console.Read();
            if(scores[array] < 0 && scores[array] > 10)
            {
                Console.WriteLine("0~10 사이의 점수를 입력해주세요");
            }
        }
    }
}
