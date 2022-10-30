using System;

class Program
{
    
    public static void Main()
    {
        int N1;
        N1 = 3;
        int[] MyNum = new int[7] ;
        MyNum[0] = 1;
        MyNum[1] = 2;
        MyNum[2] = 3;
        MyNum[3] = 4;
        MyNum[4] = 5;
        MyNum[5]= 6;
        MyNum[6] = N1;
        int tmp;
        for(int i=MyNum.Length-2 ,j= MyNum.Length-1 ; MyNum[i]> MyNum[j]; i--,j--){
            tmp = MyNum[i];
            MyNum[i] = MyNum[j];
            MyNum[j] = tmp;

        }

        for (int i = 0; i < MyNum.Length; i++)
        {
            Console.WriteLine(MyNum[i]);
        }


    }
}