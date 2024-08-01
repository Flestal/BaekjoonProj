namespace BaekjoonProj
{
    internal class _11723
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int T = int.Parse(Console.ReadLine());
            //HashSet<int> set = new HashSet<int>();
            int bit = 0;
            for(int _= 0; _ < T; _++ )
            {
                string[] input = Console.ReadLine().Split();
                int inputInt = 0;
                if( input.Length > 1 )
                    inputInt = int.Parse(input[1]);
                switch (input[0])
                {
                    case "add":
                        //set.Add(inputInt);
                        if((bit & (1 << inputInt))==0)
                            bit += 1 << inputInt;
                        break;
                    case "remove":
                        //set.Remove(inputInt);
                        if ((bit & (1 << inputInt)) == (1 << inputInt))
                            bit -= 1 << inputInt;
                        break;
                    case "check":
                        //if (set.Contains(inputInt)) sb.AppendLine("1");
                        //else sb.AppendLine("0");
                        if ((bit & (1 << inputInt)) == (1 << inputInt)) sb.AppendLine("1");
                        else sb.AppendLine("0");
                        break;
                    case "toggle":
                        bit^=(1 << inputInt);
                        //if (set.Contains(inputInt)) set.Remove(inputInt);
                        //else set.Add(inputInt);
                        break;
                    case "all":
                        bit = 2097151;
                        //set=new HashSet<int> 
                        //{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
                        break;
                    case "empty":
                        bit = 0;
                        //set = new HashSet<int>();
                        break;
                }
            }
            Console.WriteLine(sb);
        }
    }
}
