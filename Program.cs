namespace Atividades;

public class Program{
    public static void Main(string[] args){

        Console.WriteLine("List of Exercises\nChoose a Exercise from 1 to 10");
        int result = int.Parse(Console.ReadLine());
        Console.WriteLine($"You selected the {result}º Exercise\n");

        switch(result){
            case 1 : Exercise_01.Exercise();
                break;
            case 2 : Exercise_02.Exercise();
                break;
            case 3 : Exercise_03.Exercise();
                break;
            case 4 : Exercise_04.Exercise();
                break;
            case 5 : Exercise_05.Exercise();
                break;
            case 6 : Exercise_06.Exercise();
                break;
            default : Console.WriteLine("Please, choose a value from 1 to 10: ");
                break;
        }

    }

}