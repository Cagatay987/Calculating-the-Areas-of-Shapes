using System.Reflection.Metadata;

Console.ForegroundColor = ConsoleColor.Red;
float Pi = 3.14f;
float UzunkenarUzunluğu = 0;
float KısakenarUzunluğu = 0;
float Yükseklik = 0;
float Taban = 0;
float Çap = 0;

string şekilAdı;
string üçgen = "Üçgen";
string kare = "Kare";
string dikdörtgen = "Dikdörtgen";
string daire = "Daire";

Console.WriteLine("Merhaba, alan hesaplayıcı uygulamasına hoşgeldiniz.");
Console.WriteLine("Hangi şeklin alanını hesaplamak istiyorsanız onu aşağıya yazınız.");

şekilAdı = Console.ReadLine();

if (şekilAdı == üçgen || şekilAdı == kare || şekilAdı == dikdörtgen || şekilAdı == daire)
{
    AlanHesaplama();
}
else
{
    Console.WriteLine("Lütfen geçerli bir şekil ismi yazınız");
    ŞekilAdıYanlışsaSorgulama();
}

void ŞekilAdıYanlışsaSorgulama()
{
    while (şekilAdı != üçgen && şekilAdı != kare && şekilAdı != dikdörtgen && şekilAdı != daire)
    {
        şekilAdı = Console.ReadLine();

        if (şekilAdı == üçgen || şekilAdı == kare || şekilAdı == dikdörtgen || şekilAdı == daire)
        {
            AlanHesaplama();
        }
        else
        {
            Console.WriteLine("Lütfen geçerli bir şekil ismi yazınız");
        }
    }
}

void AlanHesaplama()
{
    if (şekilAdı == üçgen)
    {
        Üçgen();
    }

    if (şekilAdı == kare)
    {
        Kare();
    }

    if (şekilAdı == dikdörtgen)
    {
        Dikdörtgen();
    }

    if (şekilAdı == daire)
    {
        Daire();
    }
}

void Üçgen()
{
    Console.WriteLine("Yüksekliği giriniz:");
    while (!float.TryParse(Console.ReadLine(), out Yükseklik))
    {
        Console.WriteLine("Geçerli bir yüksekliği giriniz.");
    }

    Console.WriteLine("Tabanı giriniz:");
    while (!float.TryParse(Console.ReadLine(), out Taban))
    {
        Console.WriteLine("Geçerli bir taban giriniz.");
    }

    float üçgeninAlanı = Yükseklik * Taban / 2;
    Console.WriteLine($"Üçgenin alanı: {üçgeninAlanı}");
}

void Kare()
{
    Console.WriteLine("Kenar uzunluğunu giriniz:");
    while (!float.TryParse(Console.ReadLine(), out UzunkenarUzunluğu))
    {
        Console.WriteLine("Geçerli bir kenar uzunluğu giriniz.");
    }

    float KareninAlanı = UzunkenarUzunluğu * UzunkenarUzunluğu;
    Console.WriteLine($"Karenin alanı: {KareninAlanı}");
}

void Dikdörtgen()
{
    Console.WriteLine("UzunKenarUzunluğunu giriniz:");
    while (!float.TryParse(Console.ReadLine(), out UzunkenarUzunluğu))
    {
        Console.WriteLine("Geçerli bir UzunKenarUzunluğu giriniz.");
    }

    Console.WriteLine("KısaKenarUzunluğunu giriniz:");
    while (!float.TryParse(Console.ReadLine(), out KısakenarUzunluğu))
    {
        Console.WriteLine("Geçerli bir KısaKenarUzunluğu giriniz.");
    }

    float DikdörtgeninAlanı = UzunkenarUzunluğu * KısakenarUzunluğu;
    Console.WriteLine($"Dikdörtgenin alanı: {DikdörtgeninAlanı}");
}

void Daire()
{
    Console.WriteLine("Çap uzunluğunu giriniz:");
    while (!float.TryParse(Console.ReadLine(), out Çap))
    {
        Console.WriteLine("Geçerli bir Çap uzunluğu giriniz.");
    }

    float DaireninAlanı = Çap/2 * Çap/2 * Pi;
    Console.WriteLine($"Dairenin alanı: {DaireninAlanı}");
}
Console.ReadLine();
