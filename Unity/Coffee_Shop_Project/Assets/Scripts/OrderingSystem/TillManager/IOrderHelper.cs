//This is our interface
//It acts as a socket between two different bits of code

public interface IOrderHelper
{
    void RequestItem(string drinkType, int drinkAmount, bool orderConfirmed);
}