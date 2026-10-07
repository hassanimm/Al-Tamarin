namespace Customer
{
 public class customer
  {
    //نام
    public string Name {get; set;}
    //شماره فاکتور
    public int factornum {get; set;}
    //مبلغ خرید
    public double Price {get; set;}

    public DateTime Zaman {get; set;}

    public void placeorder()
        {
            System.Console.WriteLine($"{Customerid} order placed. ");
        }
        public void cancelorder()
        {
            System.Console.WriteLine($"{Customerid} order cancelled");
        }
  }
}