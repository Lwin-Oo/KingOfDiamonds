using System;

public static class Extensions
{
    public static int findIndex<T>(this T[] tempArray, T target) {
        return Array.IndexOf(tempArray, target);
    }

    public static int findIndex1<T>(this T[] userGuesses, T winnerValue) {
        return Array.IndexOf(userGuesses, winnerValue);
    }
    
}

namespace KingOfDiamonds
{
    class Game
    {
        public void Play()
        {
            double[] userGuesses = new double[5];
            int[] players = {1, 2, 3, 4, 5};

            Console.WriteLine("Player 1: ");
            userGuesses[0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Player 1, value stored...");

            Console.WriteLine(" ");

            Console.WriteLine("Player 2: ");
            userGuesses[1] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Player 2, value stored...");

            Console.WriteLine(" ");

            Console.WriteLine("Playerr 3: ");
            userGuesses[2] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Player 3, value stored...");
            
            Console.WriteLine(" ");

            Console.WriteLine("Player 4: ");
            userGuesses[3] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Player 4, value stored...");

            Console.WriteLine(" ");

            Console.WriteLine("Player 5: ");
            userGuesses[4] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Player 5, value stored...");

            Console.WriteLine("Your values are as Follows: ");

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(" "+ userGuesses[i]);
            }

            double sum = 0;
            foreach ( int i in userGuesses)
            {
                sum += i;
            }

            double average = sum/userGuesses.Length;
            double finalResult = average/0.8;
            List<double> tempList = userGuesses.ToList();
            tempList.Add(finalResult);
            double[] tempArray = new double[0];
            tempArray = tempList.ToArray();
            Array.Sort(tempArray);
            double target = finalResult;
            int finalIndex = tempArray.findIndex(target);


            double defAhead = finalResult - tempArray[finalIndex-1];
            double defBehind = tempArray[finalIndex+1] - finalResult;

            double winnerValue = 0.0;
            if(defBehind < defAhead)
            {
                winnerValue = tempArray[finalIndex+1];
            }
            else
            {
                winnerValue = tempArray[finalIndex-1];
            }

            int winnerIndex = userGuesses.findIndex1(winnerValue);
            int winner = winnerIndex + 1;

            Console.WriteLine("The sum is: "+ sum);
            Console.WriteLine("The average is: "+ average);
            Console.WriteLine("Final result after multiplying by constant 0.8 is: "+ finalResult);
            Console.WriteLine("Player " + winner + " is the winner. ");    

            int[] scores  = {0, 0, 0, 0, 0};
            int scoreValues = 0;

            for(scoreValues = 0; scoreValues<5 ; scoreValues++)
            {
                
                if(scoreValues == winner-1)
                {
                    scores[scoreValues] += 1; 
                }
                else 
                {
                    scores[scoreValues] += -2;
                }
                Console.WriteLine("Scores are as follows: ")
                Console.WriteLine(scores[scoreValues]);         
                
            }
            Console.Read();
            
        }
    }
    
}