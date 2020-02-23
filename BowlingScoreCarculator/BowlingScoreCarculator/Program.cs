using System;

namespace BowlingScoreCarculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            int[] scores = new int[12];
            int cntspr = 0, cntstk = 0;
            
            Console.WriteLine("10프레임동안 쓰러트린 볼링핀의 개수를 하나씩 입력해주세요.");
            for(int i = 0; i < 10; i++)
            {
                Console.Write((i + 1) + "프레임");
                String input = Console.ReadLine();
                int n = Convert.ToInt32(input);
                scores[i] = n;
                if (n < 0 || n > 10)
                {
                    Console.Write("0에서 10까지의 숫자만 입력 가능합니다.");
                    i = i - 1;
                }
                else
                {
                    if (n == 10)
                        cntstk++;
                    else
                        cntspr++;
                }
            }

            Console.WriteLine("나머지 점수는 10점으로 처리됩니다.");
            scores[10] = 10;
            scores[11] = 10;
            
            Console.WriteLine("계산중입니다......");
            for (int i = 0; i < 10; i++)
            {
                if (scores[i] == 10)
                    sum = sum + Strike(scores[i + 1], scores[i + 2]);
                else
                    sum = sum + Spare(scores[i + 1]);
            }

            Console.WriteLine("총 점수의 합계는 " + sum + " 입니다.");
            Console.WriteLine("스페어 횟수는 " + cntspr + "회 이며");
            Console.WriteLine("스트라이크 횟수는 " + cntstk + "회 입니다.");
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
    }
}
