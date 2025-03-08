using System;

class Program {
    public static void Main (string[] args) {
        //  What,      For,   Counter
        for (int i = 0; i < 9; i++) {
            Console.WriteLine(i);
    }

        // Do Statement
        int j = 5;
        do
        {
            Console.WriteLine(j);
            j--;
        }
        while (j > 0);
        
        int k = 5;
        while (k > 0)
        {
            Console.WriteLine(k);
            k--;
        }

        // Break Statement For
        for (int l = 0; l < 9; l++)
        {
            if (l == 5)
                break;
            Console.WriteLine(l);
        }
        
        

    }
}