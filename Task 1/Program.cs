double sum = 0;
int ask = 1;

while (ask == 1)
{
    Console.WriteLine("Please enter Product Price:");
    double price = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Please enter Product Quantity:");
    int quantity = Convert.ToInt32(Console.ReadLine());

    double total = price * quantity;
    Console.WriteLine($"Total Price for one = {total}");

    sum =sum+total;

    Console.WriteLine("Add another product? 1 = Yes, 0 = No:");
    ask = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Total Price for all = {sum}");