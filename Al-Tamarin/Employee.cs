namespace Hammal
{
public class Employee
{
    //نام
    public string Name {get; set;}
    //کد پرسنلی
    public int idcode {get; set;}
    //سال استخدام
    public DateTime date {get; set;}

    public void enter()
        {
            System.Console.WriteLine($"{idcode} enter submited");
        }
}
}