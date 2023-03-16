namespace Objekter_Opgaver_16_03_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Bankkonto bk1 = new Bankkonto(2000);
            Console.WriteLine("Velkommen til bankontoen skriv venligst et tal fra 1 - 3 ");

            while (true)
            {
                Console.WriteLine("1 for indsæt\n2 for udtærk\n3 for at se kontosaldo");
               var input =Convert.ToInt32( Console.ReadLine());
                
                switch (input)
                {
                    case 1:
                        Console.WriteLine("skriv mængde du vil indsætte");
                        var saldoinput = Convert.ToDecimal( Console.ReadLine());
                        bk1.deposit(saldoinput);
                    break;
                    case 2:
                        Console.WriteLine("skriv mængde du vil udtrække");
                        var saldoout = Convert.ToDecimal(Console.ReadLine());
                        bk1.withdrawl(saldoout);
                        break;
                    case 3:
                        Console.Write($"du har ");
                        bk1.Skrivsaldo(); 
                        Console.Write( " på kontoen");
                        Console.WriteLine();
                        break;
                    default: 
                    break;
                }
            }
        }
    }
}