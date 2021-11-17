using System;

class Program
{
    static void Main()
    {
        //四則演算の指定 
        string mathType;
        Console.Write("どの四則演算をしますか? 例:{+-*/}    :");
        mathType = Console.ReadLine();    

        //初めの数字の指定
        Console.Write("初めの数字を入力してください   :");
        int firstNumber = int.Parse(Console.ReadLine());

        //最後の数字の指定
        Console.Write("最後の数字を入力してください   :");
        int secondNumber = int.Parse(Console.ReadLine());

        //計算
        switch(mathType)
        {
            //+のとき
            case "+":
                ShowResult(firstNumber + secondNumber);
                break;

            //-のとき
            case "-":
                ShowResult(firstNumber + secondNumber);
                break;

            //*のとき
            case "*":
                ShowResult(firstNumber * secondNumber);
                break;

            ///のとき
            case "/":
                ShowResult(firstNumber / secondNumber);
                break;
        }

    }
    static void ShowResult(int result)
    {
        Console.WriteLine(result);
        return;
    }
}