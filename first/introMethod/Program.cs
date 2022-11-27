int a1=43;
int b1=56;
int c1=23;
int a2=35;
int b2=74;
int c2=62;
int a3=13;
int b3=78;
int c3=59;
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2>result) result=arg2;
    if(arg3>result) result=arg3;
    return result;
}
int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));
Console.WriteLine(max);
