using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycles
{
    public class Calc
    {
        public void Do()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string one = "1";
            string two = "2";
            string three = "3";

            string four = "4";
            string five = "5";
            string six = "6";

            string seven = "7";
            string eight = "8";
            string nine = "9";

            string playerX = "";
            while (true)
            {
                Console.WriteLine($"{one} | {two} | {three}");
                Console.WriteLine("----------");
                Console.WriteLine($"{four} | {five} | {six}");
                Console.WriteLine("----------");
                Console.WriteLine($"{seven} | {eight} | {nine}");

                bool validMove = false;
                //гравець 1 вводить клітинку і перевіряю чи вона не зайнята
                while (validMove == false)
                {
                    Console.WriteLine("Гравець 1 вибирає число: ");
                    playerX = Console.ReadLine();

                    switch (playerX)
                    {
                        case "1":
                            if (one == "1")
                            {
                                one = "X";
                                validMove = true;
                            }
                            break;
                        case "2":
                            if (two == "2")
                            {
                                two = "X";
                                validMove = true;
                            }
                            break;
                        case "3":
                            if (three == "3")
                            {
                                three = "X";
                                validMove = true;
                            }
                            break;
                        case "4":
                            if (four == "4")
                            {
                                four = "X";
                                validMove = true;
                            }
                            break;
                        case "5":
                            if (five == "5")
                            {
                                five = "X";
                                validMove = true;
                            }
                            break;
                        case "6":
                            if (six == "6")
                            {
                                six = "X";
                                validMove = true;
                            }
                            break;
                        case "7":
                            if (seven == "7")
                            {
                                seven = "X";
                                validMove = true;
                            }
                            break;
                        case "8":
                            if (eight == "8")
                            {
                                eight = "X";
                                validMove = true;
                            }
                            break;
                        case "9":
                            if (nine == "9")
                            {
                                nine = "X";
                                validMove = true;
                            }
                            break;
                    }

                    if (!validMove)
                    {
                        Console.WriteLine("Клітинка вже зайнята, виберіть іншу.");
                    }
                }
                //перевіряю на перемогу першого гравця
                if (one == "X" && two == "X" && three == "X"
                    || four == "X" && five == "X" && six == "X"
                    || seven == "X" && eight == "X" && nine == "X"
                    || one == "X" && five == "X" && nine == "X"
                    || three == "X" && five == "X" && seven == "X"
                    || one == "X" && four == "X" && seven == "X"
                    || two == "X" && five == "X" && eight == "X"
                    || three == "X" && six == "X" && nine == "X")
                {
                    Console.WriteLine("Перший гравець виграв");
                    break;
                }

                //перевіряю на нічию
                if (one != "1" && two != "2" && three != "3" &&
                   four != "4" && five != "5" && six != "6" &&
                   seven != "7" && eight != "8" && nine != "9")
                {
                    Console.WriteLine("Гра закінчилася внічию.");
                    break;
                }

                //гравець 2 вводить клітинку і перевіряю чи вона не зайнята
                validMove = false;
                while (validMove == false)
                {
                    Console.WriteLine("Гравець 2 вибирає число: ");
                    string playerO = Console.ReadLine();

                    switch (playerO)
                    {
                        case "1":
                            if (one == "1")
                            {
                                one = "O";
                                validMove = true;
                            }
                            break;
                        case "2":
                            if (two == "2")
                            {
                                two = "O";
                                validMove = true;
                            }
                            break;
                        case "3":
                            if (three == "3")
                            {
                                three = "O";
                                validMove = true;
                            }
                            break;
                        case "4":
                            if (four == "4")
                            {
                                four = "O";
                                validMove = true;
                            }
                            break;
                        case "5":
                            if (five == "5")
                            {
                                five = "O";
                                validMove = true;
                            }
                            break;
                        case "6":
                            if (six == "6")
                            {
                                six = "O";
                                validMove = true;
                            }
                            break;
                        case "7":
                            if (seven == "7")
                            {
                                seven = "O";
                                validMove = true;
                            }
                            break;
                        case "8":
                            if (eight == "8")
                            {
                                eight = "O";
                                validMove = true;
                            }
                            break;
                        case "9":
                            if (nine == "9")
                            {
                                nine = "O";
                                validMove = true;
                            }
                            break;
                    }

                    if (!validMove)
                    {
                        Console.WriteLine("Клітинка вже зайнята, виберіть іншу.");
                    }
                }

                //перевіряю на перемогу другого гравця
                if (one == "O" && two == "O" && three == "O"
                    || four == "O" && five == "O" && six == "O"
                    || seven == "O" && eight == "O" && nine == "O"
                    || one == "O" && five == "O" && nine == "O"
                    || three == "O" && five == "O" && seven == "O"
                    || one == "O" && four == "O" && seven == "O"
                    || two == "O" && five == "O" && eight == "O"
                    || three == "O" && six == "O" && nine == "O")
                {
                    Console.WriteLine("Другий гравець виграв");
                    break;
                }

                Console.Clear();
            }
        }
    }
}
