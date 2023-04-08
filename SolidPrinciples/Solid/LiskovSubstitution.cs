namespace SolidPrinciples.Solid;
//All superclass objects should be replaced by subclass objects
public class LiskovSubstitution
{
    //if we use the CreditCardClass and Premium CreditCard that will violate this principle
    //so we need to define a good example below
}

public interface ICreditCardUser
{
    string UserName { get; set; }
    string Address { get; set; }
}

public class PremiumCreditCardUser : ICreditCardUser
{
    public string UserName { get; set; }
    public string Address { get; set; }
}
public class NormalCreditCardUser : ICreditCardUser
{
    public string UserName { get; set; }
    public string Address { get; set; }
}
//here we can replace all interface object to its sub classes