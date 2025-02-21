Random random = new();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;


if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}

else if (daysUntilExpiration == 1)
{
    Console.WriteLine($"Your remaining days until expiry: {daysUntilExpiration}");
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage += 20;
    // Console.WriteLine($"Renew now and save {discountPercentage}%");
}

else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your remaining days until expiry: {daysUntilExpiration}");
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage += 10;
    // Console.WriteLine($"Renew now and save {discountPercentage}%.");
}

else if (daysUntilExpiration <= 10)
{
    Console.WriteLine($"Your remaining days until expiry: {daysUntilExpiration}");
    Console.WriteLine("Your subscription will expire sooon. Renew NOW!");
}
else 
{
    Console.WriteLine();
}
if (discountPercentage >  0)
{
    Console.WriteLine($"Renew Now and Save {discountPercentage}%.");
}
