internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Start();
    }

    public static void Start()
    {
        try
        {
            Console.WriteLine("\nLütfen sayılardan oluşan bir dizi giriniz:");

            int[] intArray = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
            int sumSmall = 0;
            int sumBig = 0;

            foreach (var item in intArray)
            {
                if(item <= 67) sumSmall = sumSmall + (67 - sumSmall);
                else sumBig = sumBig + Math.Abs((item - 67) * (item - 67)); 
            }

            Console.Write("{0} {1}", sumSmall, sumBig);

        }
        catch (System.Exception)
        {
            ErrorMessage();
            Start();
        }   

        EndingApp(); 
    }

    public static void ErrorMessage()
    {
        Console.WriteLine("Lütfen geçerli değer giriniz!");
    }

    public static void EndingApp()
    {
        Console.WriteLine("\nLütfen yapmak istediğiniz işlemi seçiniz: \n" +
                          "********************************************************* \n" +
                          "(1) Programı sonlandır \n" +
                          "(2) Programı tekrar başlat \n");  

        string choice = Console.ReadLine();
        if(choice.Contains('1')) Environment.Exit(0);
        else if(choice.Contains('2')) Start();
        else {ErrorMessage(); EndingApp();}
    }

}