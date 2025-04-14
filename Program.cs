namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("******Menu******\r\n 1.Sisteme giris\r\n 0.Cixis");
                string secim;
                secim = Console.ReadLine();
                switch (secim)
                {
                    case "0":
                        return;
                    case "1":
                        SubMenu();
                        break;
                }

            }
        }
        public static void SubMenu()
        {
            Hotel hotel = new Hotel("GreenCity");
            while (true)
            {
                Console.WriteLine("1.Room yarat\r\n2.Roomlari gor\r\n3.Rezervasya et(eger hec bir otaq yoxdursa rezervasya xidmeti islemir)\r\n4.Evvelki menuya qayit.\r\n0.Exit");
                string secim;
                secim = Console.ReadLine();
                switch (secim) 
                { 
                    case "0":
                        return ;
                        case "1":
                        Room room=new Room();
                        Console.WriteLine("OTAGIN adini daxil edin:");
                        string name=Console.ReadLine();
                        Console.WriteLine("otagin qiymetini daxil edin:");
                            int price=int.TryParse(Console.ReadLine(),);  

                }
            }
        }
    }
}

