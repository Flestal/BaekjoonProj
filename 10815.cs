namespace BaekjoonProj
{
    internal class _10815
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int N = int.Parse(Console.ReadLine());
            int[] cards = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int M = int.Parse(Console.ReadLine());
            int[] check = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(cards);
            int start, end, mid;
            for(int i=0; i < check.Length; i++)
            {
                bool flag = false;
                start = 0;end=cards.Length - 1;
                while (start<=end)
                {
                    mid = (start + end) / 2;
                    if (cards[mid] == check[i])
                    {
                        flag = true;break;
                    }
                    else if (cards[mid] > check[i])
                    {
                        end = mid-1;
                    }
                    else if (cards[mid] < check[i])
                    {
                        start = mid+1;
                    }
                }
                if (flag)
                {
                    sb.Append("1 ");
                }
                else
                {
                    sb.Append("0 ");
                }
            }
            sb.Remove(sb.Length - 1, 1);
            Console.WriteLine(sb);

        }
    }
}
