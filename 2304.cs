namespace BaekjoonProj
{
    internal class _2304
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int max = 0;
            int maxIdx1,maxIdx2;
            (int, int)[] bars = new (int, int)[N];
            int[] input;
            for(int i = 0; i < N; i++)
            {
                input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if (input[1] > max) max = input[1];
                bars[i] = (input[0], input[1]);
            }
            bars = bars.OrderBy(x => x.Item1).ToArray();
            int cur = bars[0].Item2;
            int idx = bars[0].Item1;
            maxIdx1 = idx;
            int sum = 0;
            for(int i=1;i < bars.Length; i++)
            {
                if (bars[i].Item2 > cur)
                {
                    Console.Write(
                        bars[i].Item1
                        + " 위치에서 높이 증가 발생 : "
                        + cur + " -> " + bars[i].Item2
                        +", 현재 누적 면적 : " + sum
                        +", 새로 누적되는 면적 : "+((bars[i].Item1 - idx) * cur)
                        );
                    sum += (bars[i].Item1 - idx) * cur;
                    Console.WriteLine(", 새로운 누적 면적 : " + sum);
                    if (bars[i].Item2 == max && maxIdx1 == bars[0].Item1)
                    {
                        maxIdx1 = bars[i].Item1;
                        Console.WriteLine("최대 높이 도달, 왼쪽에서 잰 최대높이 위치 : " + maxIdx1);
                    }
                    cur = bars[i].Item2;
                    idx = bars[i].Item1;
                }
            }
            cur= bars[bars.Length-1].Item2;
            idx= bars[bars.Length-1].Item1;
            maxIdx2 = idx;
            for (int i = bars.Length-2; i >=0; i--)
            {
                if (bars[i].Item2 > cur)
                {
                    Console.Write(
                        bars[i].Item1
                        + " 위치에서 높이 증가 발생 : "
                        + cur + " -> " + bars[i].Item2
                        + ", 현재 누적 면적 : " + sum
                        + ", 새로 누적되는 면적 : " + ((idx - bars[i].Item1) * cur)
                        );
                    sum += (idx - bars[i].Item1) * cur;
                    Console.WriteLine(", 새로운 누적 면적 : " + sum);
                    if (bars[i].Item2 == max && maxIdx2 == bars[bars.Length - 1].Item1)
                    {
                        maxIdx2 = bars[i].Item1;
                        Console.WriteLine("최대 높이 도달, 오른쪽에서 잰 최대높이 위치 : " + maxIdx2);
                    }
                    cur = bars[i].Item2;
                    idx = bars[i].Item1;
                }
            }
            sum += max*(maxIdx2-maxIdx1+1);
            Console.WriteLine(sum);
        }
    }
}
