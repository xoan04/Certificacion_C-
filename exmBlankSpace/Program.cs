/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */


string originalMessage = "The quick brown fox jumps over the lazy dog.";
char[] charMessage = str.ToCharArray(); // convert the message into a char array
int o = 0; // count the o's

// Reverse the chars
Array.Reverse(charMessage);


foreach (char letter in charMessage) 
{ 
    if (letter == 'o') 
    { 
        o++; 
    } 
}

string new_message = new String(charMessage);// convert it back to a string

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {o} times.");