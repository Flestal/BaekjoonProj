namespace BaekjoonProj
{
    internal class _9017
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] switches = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int T = int.Parse(Console.ReadLine());
            void toggle(int where)
            {
                if (switches[where - 1] == 0)
                {
                    switches[where-1] = 1;
                }
                else
                {
                    switches[where - 1] = 0;
                }
            }
            for(int _ = 0; _ < T; _++)
            {
                int[] control = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if (control[0] == 1)
                {
                    for(int i = 0; i < N; i++)
                    {
                        if ((i + 1) % control[1] == 0)
                        {
                            toggle(i+1);
                        }
                    }
                }
                else
                {
                    int length = Math.Min(control[1], N - control[1]+1);
                    toggle(control[1]);
                    for(int i = 0; i < length; i++)
                    {
                        
                        if (switches[control[1] + i - 1] == switches[control[1] - i - 1])
                        {
                            toggle(control[1] + i);
                            toggle(control[1] - i);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            //sb.Append(switches[0]);
            for(int i=0;i< N; i++)
            {
                if (i % 20 != 0) sb.Append(' ');
                sb.Append(switches[i]);
                if (i % 20 == 19) sb.AppendLine();
            }
            Console.WriteLine(sb);
        }
    }
}
