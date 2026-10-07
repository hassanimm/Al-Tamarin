namespace Teacher
{
public class Teacher
{
    //نام
    public string Name {get; set;}
    //درس
    public string Lesson {get; set;}
    //سن
    public int Age {get; set;}

    public void enter()
        {
            System.Console.WriteLine($"{idcode} enter submited");
        }

}
}