string permission = "DIRector";
int level = 0;

if(permission.ToLower().Contains("admin"))
{
    Console.WriteLine($"Welcome {(level>55?"Super Admin User":"Admin User")}");
}

else if(permission.ToLower().Contains("director"))
{
    Console.WriteLine($"{(level>20?"Contact an Admin for access.":"You do not have sufficient privileges.")}");
}
else
{
    Console.WriteLine("You do not have sufficient privileges :( .");
}