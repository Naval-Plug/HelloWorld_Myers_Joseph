using System.Security.Cryptography.X509Certificates;

namespace HelloWorld_Myers_Joseph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ask for name and input prompt
            
            Console.WriteLine("What is your name, ahh, full name soldier?");
            //store name and askes for alligence
        string userName = Console.ReadLine();
            Console.WriteLine(userName +", do you serve the God-Emperor of Mankind? Yes or no for simplicity please.");
string answerQ = Console.ReadLine();
            if (answerQ == "yes")
            {
                Console.WriteLine("The go serve your purpose and die for your Imperium gaurdsman.");
            }
            else if(answerQ =="no" )
            {
                Console.WriteLine("I have no use for a soldier without faith, I will have you sevitored.");
            }   
            else 
            {
                Console.WriteLine("If you won't answer my question correctly then i will have you servitored.");
            }
       }
    }
}
