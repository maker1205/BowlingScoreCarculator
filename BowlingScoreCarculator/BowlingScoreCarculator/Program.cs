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
            scores[10] = 10;
            scores[11] = 10;

            Console.WriteLine("계산중입니다......");
            for (int i = 0; i < 10; i++)
            {
                if (scores[i] == 10)
                {
                    sum = sum + Strike(scores[i + 1], scores[i + 2]);
                }
                else
                {
                    sum = sum + Spare(scores[i + 1]);
                }
            }

            Console.WriteLine("총 점수의 합계는 " + sum + " 입니다.");
        }

        private static int Spare(int score)
        {
            var eachFrameSum = 0;
            eachFrameSum = 10 + score;
            return eachFrameSum;
        }

        private static int Strike(int score1,int score2)
        {
            var eachFrameSum = 0;
            eachFrameSum = 10 + score1 + score2;
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
