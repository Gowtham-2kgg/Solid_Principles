namespace SolidPrinciples.Solid;

public class DependencyInversion
{
    //Low Level and High level classes must be independent
    //High must not depends on Low and Low must now on High
    //Both must depend on Abstraction and Abstraction must depends on details
    
    //int he example of single responsibility credit card uses User but it can be modified 
}

public interface ICardUser
{
    public ICreditCardUser CreditCardUser { get; set; }
    public void MakePayment(int amount);
}

public class CardUser : ICardUser
{
    public ICreditCardUser CreditCardUser { get; set; }
    public void MakePayment(int amount)
    {
        //do something
    }
}