namespace BaekjoonProj
{
    internal class _10816
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int N = int.Parse(Console.ReadLine());
            int[] cards = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Dictionary<int,int> cards_ = new Dictionary<int,int>();
            foreach (int card in cards)
            {
                if (!cards_.ContainsKey(card))
                {
                    cards_.Add(card, 1);
                }
                else
                {
                    cards_[card]++;
                }
            }
            int M = int.Parse(Console.ReadLine());
            int[] check = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(cards);
            for(int i=0; i < check.Length; i++)
            {
                if (cards_.ContainsKey(check[i]))
                {
                    sb.Append(cards_[check[i]]).Append(" ");
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
