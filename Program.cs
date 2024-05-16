namespace Orchard {
    public class Program {
        public static void Main()
        {
            string[] crops = {"apple", "pear", "apricot", "cherry", "plum"};
            Orchard[] orchards = new Orchard[20];

            Dictionary<string, int> yields = new Dictionary<string, int>();

            for (int x = 0; x < orchards.Length; x++)
            {
                Random rand = new Random();
                Orchard temp = new Orchard(rand.Next(1, 10), rand.Next(1, 10), crops[rand.Next(0, 5)], rand.Next(1, 10), rand.Next(1, 10));
                orchards[x] = temp;

                yields[temp.Plant] = yields.ContainsKey(temp.Plant)
                    ? yields[temp.Plant] += temp.Harvest()
                    : temp.Harvest();
            }
            
            for (int x = 0; x < yields.Count; x++)
            {
                string msg = "";
                msg = yields.ContainsKey(crops[x]) ? $"{crops[x]}: {yields[crops[x]]}kg" : $"{crops[x]}: 0kg";
                Console.WriteLine(msg);
            }

        }
    }
}