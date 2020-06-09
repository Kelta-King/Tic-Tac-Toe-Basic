using System;
using System.Threading;

namespace TIC_TAC_TOE
//name space is TIC_YTAC_TOE
{

    class Program{
    
    static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int player = 1; //By default player 1 is set  
    static int choice; //This holds the choice at which position user want to mark   
		
		
		//flag iss for checking the match status. if flag = 1 then someone won the game 
		//and if flag = -1 then match is draw and if 0 then match is still going
    static int flag = 0;

    static void Main(string[] args){

        do{

             Console.Clear();// whenever loop will be again start then screen will be clear  
             Console.WriteLine("Player1:X and Player2:O");
             Console.WriteLine("\n");
             if(player % 2 == 0){
                 Console.WriteLine("Player 2 Chance");
             }
             else
             {
                 Console.WriteLine("Player 1 Chance");
             }

             Console.WriteLine("\n");
             Board();// calling the board Function  
             choice = int.Parse(Console.ReadLine());//Taking users choice   

             if (arr[choice] != 'X' && arr[choice] != 'O'){

				        if (player % 2 == 0){
                     arr[choice] = 'O';
                     player++;
                }
                else
                {
                     arr[choice] = 'X';
                     player++;
                }
            }
            else{
                 Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, arr[choice]);
                 Console.WriteLine("\n");
                 Console.WriteLine("Please wait 2 second board is loading again.....");
                 Thread.Sleep(2000);
            }

            flag = CheckWin();// calling of check win  

        }while (flag != 1 && flag != -1);
        // This loop will be run until all cell of the grid is not marked with X and O or some player is not win  

            Console.Clear();// clearing the console  
            Board();// getting filled board again  

            if (flag == 1)// if flag value is 1 then some one has win or means who played marked last time which has win  
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }
            else// if flag value is -1 the match will be draw and no one is winner  
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }
    
    }

}
