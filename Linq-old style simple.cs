            int[] temp = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var k = from t in temp
                    where t > 3
                    select t;
            foreach (int i in k)
                Console.WriteLine(i);
            string[] temp2 = new string[] { "a", "b", "c", "d", "e" };
            var l = from m in temp2
                    where m == "a" || m == "d"
                    select m;
            foreach (string j in l)
            {
                Console.WriteLine(j);
            }
            Console.ReadLine();