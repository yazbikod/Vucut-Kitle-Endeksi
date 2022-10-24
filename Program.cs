Console.WriteLine("Vücut Kitle Endeksi Hesaplayıcı");
Console.WriteLine("Kilonuzu Giriniz : ");
int kilo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Boyunuzu Giriniz : ");
double boy = Convert.ToDouble(Console.ReadLine());
double endeks = kilo / (boy * boy);
if (endeks < 18)
{
    Console.WriteLine("Zayıfsınız...:/ ");
}
else if (endeks >= 18 && endeks <= 25)
{
    Console.WriteLine("Normalsiniz...:) ");
}
else if (endeks > 25)
{
    Console.WriteLine("Obezsiniz... :(");
}