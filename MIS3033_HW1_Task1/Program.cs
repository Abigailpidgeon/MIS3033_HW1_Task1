// MIS 3033 HW1
// Task 1

const double cogprice = 79.99;
const double gearprice = 250.00;
const double normalmarkup = 0.15;
const double discountmarkup = 0.125;
const double salestaxrate = 0.089;

int numofcogs;
int numofgears;

double normalsubtotal;
double actualsubtotal;
double discountamount;
double salestaxamount;
double total;
double actualmarkup;

String outmesg = "Please input the number of cogs:";
Console.Write(outmesg);
string input = Console.ReadLine();
numofcogs = Convert.ToInt32(input);

outmesg = "Please input number of gears:";
Console.Write(outmesg);
input = Console.ReadLine(); 
numofgears = Convert.ToInt32(input);

if (numofcogs > 10 || numofgears > 10 || numofcogs + numofgears > 16)
{
    actualmarkup = 0.125;
}
else
{
    actualmarkup = 0.15;
}

normalsubtotal = (numofcogs * cogprice + numofgears * gearprice) * (1 + normalmarkup);
actualsubtotal = (numofcogs * cogprice + numofgears * gearprice) * (1 + actualmarkup);
discountamount = normalsubtotal - actualsubtotal;
salestaxamount = actualsubtotal * salestaxrate;
total = actualsubtotal + salestaxamount;

outmesg = "Recipt";
Console.WriteLine(outmesg);
outmesg = string.Format($"Num. Of Cogs: {numofcogs}");
Console.WriteLine(outmesg);
outmesg = string.Format($"Num. Of Gears: {numofgears}");
Console.WriteLine(outmesg);
outmesg = string.Format($"Subtotal: {actualsubtotal:C2}");
Console.WriteLine(outmesg);
outmesg = string.Format($"Discount: {discountamount:C2}");
Console.WriteLine(outmesg);
outmesg= string.Format($"Sales tax: {salestaxamount:C2}");
Console.WriteLine(outmesg);
outmesg= string.Format($"Grand Total: {total:C2}");
Console.WriteLine(outmesg);

