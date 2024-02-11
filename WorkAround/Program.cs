// See https://aka.ms/new-console-template for more information





using Business.Concrete;
using Entities.Concrete;

SelamVer(isim: "ahmet");
SelamVer(isim: "ayse");
SelamVer();

int sonuc = Topla(6, 58);


//Diziler - Arrays

string student1 = "Engin";
string student2 = "Fatih";
string student3 = "Berkay";

//Console.WriteLine(student1);
//Console.WriteLine(student2);
//Console.WriteLine(student3);

string[] student = new string[3];
student[0] = "Engin";
student[1] = "Fatih";
student[2] = "Berkay";

student = new string[4];
student[3] = "Lokum";


for(int i=0; i<student.Length; i++)
{
    Console.WriteLine(student[i]);
}

string[] sehirler1 = new[] { "Ankara", "İstanbul", "izmir" };
string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);

Person person1 = new Person();
person1.FirstName = "HANDE";
person1.LastName = "MENCİK";
person1.DateOfBirthYear = 2000;
person1.NationalIdentity = 29404053726;


Person person2 = new Person();
person2.FirstName = "Murat";

foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}
// bu yapı hiç olmasaydı mylist kendin yaz
List<string> yeniSehirler1 = new List<string> { "Antalya", "istanbul", "ısparta" };
yeniSehirler1.Add(item: "mersin");
foreach (var sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);  
}



PttMenager pttMenager = new PttMenager(new PersonMenager());
pttMenager.GiveMask(person1);



Console.ReadLine();


static void SelamVer(string isim = "default isimsiz")
{
    Console.WriteLine("merhaba " + isim);
}
//resharper
static int Topla(int sayi1 = 2, int sayi2 = 8)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam: " + sonuc.ToString());
    return sonuc;
}




//public class Community
//{
//    public string Name { get; set; }
//    public string Surname { get; set; }
//    public int BirthYear { get; set;}
//    public long Identification { get; set;}


