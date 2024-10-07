// See https://aka.ms/new-console-template for more information
using OpenClosePrinciple;

//Before 
Discount _flatDiscount = new Discount();
_flatDiscount.Calculate(1000);

Discount _seasonalDiscount = new Discount();
_seasonalDiscount.Calculate(1000);  //will still show 10% discount as we cannot modify existing class


//After
IDiscount flatDiscount = new FlatDiscount();
flatDiscount.Calculate(1000);   //10% discount

IDiscount seasonalDiscount = new SeasonalDiscount();
seasonalDiscount.Calculate(1000);   //20% discount