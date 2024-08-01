namespace BaekjoonProj
{
    internal class _1450
    {
        
        public static void Run(string[] args)
        {
            List<int> Subset(int[] arr, int max)
            {
                List<int> res = new List<int>();
                for (int i = 0; i < (1 << arr.Length); i++)
                {
                    int sum = 0;
                    bool over = false;
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if ((i & (1 << j)) != 0)
                        {
                            sum += arr[j];
                            if (sum > max)
                            {
                                over = true;
                                break;
                            }
                        }
                    }
                    if (!over)
                    {
                        res.Add(sum);
                    }
                }
                res.Sort();
                return res;
            }

            int[] NC = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] W = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int res = 0;
            
            float lenHalf = W.Length / 2f;
            int[] W1=new int[(int)(lenHalf + 0.5f)], W2=new int[(int)lenHalf];
            for (int i=0; i < (int)(lenHalf + 0.5f); i++)
            {
                W1[i] = W[i];
            }
            for(int i=0;i< (int)lenHalf; i++)
            {
                W2[i] = W[i + (int)(lenHalf + 0.5f)];
            }
            List<int> sub1, sub2;
            sub1 = Subset(W1, NC[1]).ToList();
            sub2 = Subset(W2, NC[1]).ToList();
            int p1 = 0, p2 = sub2.Count - 1;
            while (p1 < sub1.Count && p2 >= 0)
            {
                if (sub1[p1] + sub2[p2] > NC[1])
                {
                    p2--;
                }
                else
                {
                    res+=p2+1;
                    p1++;
                }
            }
            Console.WriteLine(res);
        }
    }
}
