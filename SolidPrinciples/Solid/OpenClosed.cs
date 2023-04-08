namespace SolidPrinciples.Solid;
//This suggest class must never be modified but can always be extended
//During software dev and maintain phase new features might be required
//to handle that we need to add functions without modifying existing one
//by adding a subclass or by adding a new method or adding new interface
public class OpenClosed
{
    //suppose we need to have premium credit card or membership which add
    //advantage to cc we don't have to add a new member and awhile creating we don't
    //need to add if or switch we can create a subclass instead
}

public class PremiumCreditCard : CreditCard
{
    protected internal override void MakePayment(CreditCard creditCard, int amount)
    {
        amount += 100;
        base.MakePayment(creditCard, amount);
    }
}