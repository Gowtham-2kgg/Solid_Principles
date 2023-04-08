namespace SolidPrinciples.Solid;
//Class must have only one reason to get change - class must be used only for one purpose
//if we use it for multiple purpose then bugs might be difficult to resolve, understandability is 0 also code smells
public class SingleResponsibility
{
    
}

public class User
{
    public string UserName { get; set; }
    public string UserAddress { get; set; }
    
}

public class CreditCard
{
    private User CreditCardUser { get; set; }
    private int CreditedAmount { get; set; }

    protected internal CreditCard CreateCard()
    {
        return new CreditCard()
        {
            CreditCardUser = new User()
            {
                UserAddress = "Pune",
                UserName = "Gowtham"
            }
        };
    }
    protected internal virtual void MakePayment(CreditCard creditCard, int amount)
    {
        creditCard.CreditedAmount += amount;
    }
}

//here in this example we can see credit card got 2 responsibilities one is Creating card and one is making payment