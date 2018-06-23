using System;
using System.Collections.Generic;
using Bingo.WcfBingo;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new ServiceBingoClient())
            {
                Console.Write("How many players do you want: ");
                if(int.TryParse(Console.ReadLine(), out int amout))
                {
                    List<Board> Players = client.GenerateBoards(amout);
                    List<Board> WinningPlayers = new List<Board>();
                    Board WinningPattern = client.GenerateWinningPattern();

                    Random rnd = new Random();
                    int RandomIndex;

                    List<int> PlayedNumbers = new List<int>();
                    List<int> RemainingNumbers = new List<int>();
                    for (int i = 1; i <= 75; i++)
                        RemainingNumbers.Add(i);

                    do
                    {
                        RandomIndex = rnd.Next(RemainingNumbers.Count);
                        PlayedNumbers.Add(RemainingNumbers[RandomIndex]);
                        RemainingNumbers.RemoveAt(RandomIndex);

                        client.MarkBoards(ref Players, PlayedNumbers.Last());
                        WinningPlayers = client.GetWinningBoards(Players, WinningPattern);
                    } while (WinningPlayers.Count == 0);

                    for(int i = 0; i < WinningPlayers.Count; i++)
                    {
                        Console.Clear();

                        Console.WriteLine($"{WinningPlayers.Count} players won!!\n");
                        Console.WriteLine($"The player number {i} had the board: ");
                        for (int j = 0; j < 5; j++)
                        {
                            for (int k = 0; k < 5; k++)
                            {
                                Console.Write(WinningPlayers[i].GameBoard[j][k].Value + "\t");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine($"\nThe winning pattern was: ");
                        for (int j = 0; j < 5; j++)
                        {
                            for (int k = 0; k < 5; k++)
                            {
                                Console.Write((WinningPattern.GameBoard[j][k].IsMarked) ? "X\t" : "-\t");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine($"\nThe played numbers were: {String.Join(",", PlayedNumbers)}");

                        if (i != WinningPlayers.Count - 1)
                            Console.WriteLine("\nPress enter to see the next winner . . .");
                        else
                            Console.WriteLine("\nPress enter to exit the game . . .");

                        Console.ReadKey();
                    }

                }
                else
                {
                    Console.WriteLine("Error with the number of players, press any key to exit");
                    Console.ReadKey();
                }
            }
        }
    }
}
