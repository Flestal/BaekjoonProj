
namespace BaekjoonProj
{
    internal class _14888
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] oper = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] temp = new int[N];
            int min = int.MaxValue,max = int.MinValue,res=A[0];

            void Operation(int cur)
            {
                if (cur == N)
                {
                    if (res > max)
                    {
                        max = res;
                    }
                    if(res<min)
                    {
                        min = res;
                    }
                    return;
                }
                else
                {
                    for(int i = 0; i < oper.Length; i++)
                    {
                        temp[cur] = res;
                        if (oper[i] == 0)
                        {
                            continue;
                        }
                        switch(i)
                        {
                            case 0:
                                res += A[cur];
                                oper[i] -= 1;
                                Operation(cur + 1);
                                oper[i] += 1;
                                res = temp[cur];
                                break;
                            case 1:
                                res -= A[cur];
                                oper[i] -= 1;
                                Operation(cur + 1);
                                oper[i] += 1;
                                res = temp[cur];
                                break;
                            case 2:
                                res *= A[cur];
                                oper[i] -= 1;
                                Operation(cur + 1);
                                oper[i] += 1;
                                res = temp[cur];
                                break;
                            case 3:
                                res/= A[cur];
                                oper[i] -= 1;
                                Operation(cur + 1);
                                oper[i] += 1;
                                res = temp[cur];
                                break;
                        }
                    }
                }
            }
            Operation(1);
            Console.WriteLine(max);
            Console.WriteLine(min);

        }
    }
}
