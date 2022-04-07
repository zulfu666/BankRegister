// See https://aka.ms/new-console-template for more information


//Console.Write("Istifadeci adinizi daxil edin:");

//var point = Console.ReadLine();

//int checkPoint = Convert.ToInt32(point);

//if (point = true )
//{
//    Console.WriteLine("Zehmet olmasa bal secin");
//}
//else if (checkPoint < 51)
//{
//    Console.WriteLine("Kesildiniz.");

//}


string banKNum = "0123456789";
string banKPass = "1234";

Console.WriteLine("Kart nomresini daxil edin");
string num = Console.ReadLine();

Console.WriteLine("Kodu daxil edin");
string pass = Console.ReadLine();


if (num == banKNum && pass == banKPass)
{
    Console.WriteLine("daxil oldunuz");
    Console.WriteLine("Hesabiniz: 500man");
    Console.WriteLine("cixaris etmek isteyirsiniz?");
    Console.WriteLine("he/yox");

    string answer = Console.ReadLine();
    if (answer == "he")
    {
        Console.WriteLine("Cixarisin meblegi:");
        string price = Console.ReadLine(); ;
        int prices = Convert.ToInt32(price);

        int accaount = 500;
        if (prices <= accaount)
        {
            Console.WriteLine("cixaris ugurla tamamlandi");
            int result = accaount - prices;
            Console.WriteLine("Hesabda olan mebleg:" + result + "man");
        }
        else
        {
            Console.WriteLine("cixaris mumkun deyil");
        }
    }
    else if (answer == "yox")
    {
        Console.WriteLine("cixaris olmadi, tesekkurler");

    }


}
else if (num == "" && pass == "")
{
    Console.WriteLine("melumatlari daxil edin");
}

else
{
    Console.WriteLine("daxil ola bilmediniz");
    if (num != banKNum)
    {
        Console.WriteLine("bank nomresini duzgun daxil edin");
    }
    else if (pass != banKPass)
    {
        Console.WriteLine("sifreni duzgun daxil edin");
    }
}
