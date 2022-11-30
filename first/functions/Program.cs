// type 1

/* void Method1()
{
    Console.WriteLine("Autor is ...");
}
Method1();*/

//type 2

/* void Method2(string msg, int count)
{
    int i=0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method2(msg: "msgg", count: 3); */

//type 3

/* int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year); */

//type 4

string Method4(int count, string text)
{
    int i=0;
    string result=String.Empty;
    while (i<count)
    {
      result=result+text;  
      i++;
    }
    return result;
}
string res = Method4(10, "u");
Console.WriteLine(res);