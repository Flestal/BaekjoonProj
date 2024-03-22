namespace BaekjoonProj
{
    internal class _1515
    {
        public static void Run(string[] args)
        {
            string input = Console.ReadLine();
            int i = 0;
            char[] digit = new char[5];//최대 5자리까지
            while (input.Length>0)
            {
                i++;
                if (i > 9999)
                    digit[0] = (char)((i%100000) / 10000 + '0');
                else digit[0] = 'N';
                if (i > 999)
                    digit[1] = (char)((i%10000) / 1000 + '0');
                else digit[1] = 'N';
                if (i > 99)
                    digit[2] = (char)((i%1000) / 100 + '0');
                else digit[2] = 'N';
                if (i > 9)
                    digit[3] = (char)((i%100) / 10 + '0');
                else digit[3] = 'N';
                digit[4] = (char)(i % 10+'0');
                if (input.Length > 0 && input[0] == digit[0])input=input.Substring(1);
                if (input.Length > 0 && input[0] == digit[1])input=input.Substring(1);
                if (input.Length > 0 && input[0] == digit[2])input=input.Substring(1);
                if (input.Length > 0 && input[0] == digit[3])input=input.Substring(1);
                if (input.Length > 0 && input[0] == digit[4])input=input.Substring(1);
            }
            Console.WriteLine(i);
        }
    }
}
