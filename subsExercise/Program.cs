Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;


if (daysUntilExpiration == 0)
{
    Console.WriteLine($"¡Tu suscripcion ha expirado! ");
}
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    Console.WriteLine($"Tu suscripcion expira en {daysUntilExpiration} dias \n Renuevala con {discountPercentage}% de descuento ");
}
else if (daysUntilExpiration <= 5)
{
    discountPercentage = 10;
    Console.WriteLine($"Tu suscripcion expira en {daysUntilExpiration} dias \n Renuevala con {discountPercentage}% de descuento ");

}
else if (daysUntilExpiration <=10 )
{
    Console.WriteLine($"Tu suscripcion expira en {daysUntilExpiration} dias renuevala pronto");
}