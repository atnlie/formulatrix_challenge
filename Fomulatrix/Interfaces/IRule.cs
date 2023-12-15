namespace Fomulatrix
{
	public interface IRule
	{
        bool IsSatisfied(int number);
        string GetOutput();
    }
}
