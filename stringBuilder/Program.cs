using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder("Hello to all");
  

        StringBuilder sb2 = new StringBuilder(20);


        Console.WriteLine(sb);
        Console.WriteLine(sb.GetHashCode());

        sb.Append(" Good Morning");
        Console.WriteLine(sb);
        Console.WriteLine(sb.GetHashCode());

        sb.Insert(5, " TEST DATA");
        sb.Remove(5, 5);

        sb.Replace("DATA", "new data");
        Console.WriteLine(sb);


        StringBuilder sb3 = new StringBuilder("Your amount is ");     

        sb3.AppendFormat("{0:C}", 25000); 

        Console.WriteLine(sb3);

    }
}