namespace BaekjoonProj
{
    internal class _2346
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            LinkedList<int[]> dq = new LinkedList<int[]>();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int key=0;
            int[] command = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
            foreach(int i in command)
            {
                dq.AddLast(new int[] {key+1,i});
                key++;
            }
            key = 0;
            int move;
            while(dq.Count > 0)
            {
                sb.Append(dq.First()[0]).Append(" ");
                move = dq.First()[1];
                dq.RemoveFirst();
                if (dq.Count == 0)
                {
                    break;
                }
                if (move > 0)
                {
                    for (int i = 0; i < move-1; i++)
                    {
                        dq.AddLast(dq.First());
                        dq.RemoveFirst();
                    }
                }
                else
                {
                    move = -move;
                    for (int i = 0; i < move; i++)
                    {
                        dq.AddFirst(dq.Last());
                        dq.RemoveLast();
                    }
                }
                
            }
            sb.Remove(sb.Length - 1, 1);
            Console.Write(sb);
        }
    }
}
