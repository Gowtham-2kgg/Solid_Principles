namespace SolidPrinciples.Solid;

public class InterfaceSegregation
{
    //Interface must not be fatty - have to be small
    //Class inherits interface must implement all its method
}

public interface ITax
{
    public int Salary { get; set; }
    public int Tax { get; set; }
    public bool IsNewRegime { get; set; }
    // public void CalculateNewRegime(int salary, int tax);
    // public void CalculateOldRegime(int salary, int tax);
    
}

public interface INewTaxCalculator
{
    public void CalculateNewRegime(int salary, int tax);
    // public void CalculateOldRegime(int salary, int tax);
}

public interface IOldTaxCalculator
{
    public void CalculateOldRegime(int salary, int tax);
}

public class NewTaxCalculator : ITax, INewTaxCalculator
{
    public int Salary { get; set; }
    public int Tax { get; set; }
    public bool IsNewRegime { get; set; }
    public void CalculateNewRegime(int salary, int tax)
    {
        salary = salary - tax;
    }
}

public class OldTaxCalculator : ITax, IOldTaxCalculator
{
    public int Salary { get; set; }
    public int Tax { get; set; }
    public bool IsNewRegime { get; set; }
    public void CalculateOldRegime(int salary, int tax)
    {
        salary = salary - tax + salary/2;
    }
}
