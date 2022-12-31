using System;


namespace KingOfDiamonds
{
            

    class Program
    {
        

        static void Main(string[] args)
        {
            var game = new Game();
            Welcome theMessage = new Welcome();
            theMessage.Print();

            Game theGame = new Game();

            while(true)
            {   
                theGame.Play();
                
            }
            
        }

            
    }
}
