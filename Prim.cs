

using System;

class Primary

{

public static void Main ()

    {

        Multiplication mark = new Multiplication();
        mark.multiply();

        Addition diamond = new Addition();
        int c=diamond.add(10, 66);
        System.Console.WriteLine("The sum is =" + c);

        Decision silver = new Decision();
        silver.logic(5,15);

        Console.ReadKey();

    }


}

