namespace BaekjoonProj
{
    internal class _9935
    {
        public static void Run(string[] args)
        {
            string input = Console.ReadLine();
            string pung = Console.ReadLine();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            List<char> chars = new List<char>();
            foreach(char c in input)
            {
                chars.Add(c);
                if(chars.Count >=pung.Length)
                {
                    bool flag = true;
                    for(int i=0;i<pung.Length;i++)
                    {
                        if (chars[chars.Count-pung.Length+i] != pung[i])
                        {
                            flag = false;
                        }
                    }
                    if (flag)
                    {
                        chars.RemoveRange(chars.Count-pung.Length,pung.Length);
                    }
                }
            }
            if(chars.Count>0)
            {
                for (int i = 0; i < chars.Count; i++)
                {
                    sb.Append(chars[i]);
                }
            }
            else
            {
                sb.Append("FRULA");
            }
            
            Console.WriteLine(sb);
        }
    }
}
