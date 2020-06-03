using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TV
    {
        public static int currentChannel = 1;

        static void Main(string[] args)
        {
            Console.WriteLine("Текущий канал : 1" +
                              "\nВсего каналов : 31" +
                              "\nЕсли вы хотите переключить канал на следующий - нажмите N" +
                              "\nЕсли вы хотите переключить канал на предыдущий - нажмите P"+
                              "\nЕсли вы хотите переключить канал по номеру - нажмите O\n");

            string NextPreviousOther;
            while (true)
            {
                do
                {
                    NextPreviousOther = Console.ReadLine();

                    if (NextPreviousOther == "P")
                    {
                        if (currentChannel == 1)
                        {
                            currentChannel = 31;
                        }
                        else
                        {
                            currentChannel--;
                        }
                        
                        Console.WriteLine($"Вы переключили канал на {currentChannel}\n");
                    }
                    if (NextPreviousOther == "N")
                    {
                        if (currentChannel == 31)
                        {
                            currentChannel = 1;
                        }
                        else
                        {
                            currentChannel++;
                        }
                        Console.WriteLine($"Вы переключили канал на {currentChannel}\n");
                    }
                    if (NextPreviousOther == "O")
                    {
                        Console.Write("Введите канал : ");
                        int channel;
                        bool isInt = int.TryParse(Console.ReadLine(), out channel);
                        if(isInt)
                            switchChannel(channel);
                    }
                    if((NextPreviousOther == "P") && (NextPreviousOther == "N") && (NextPreviousOther == "O"))
                    {
                        Console.WriteLine("Введите P, N или O\n");
                    }
                }
                while ((NextPreviousOther != "P") && (NextPreviousOther != "N") && (NextPreviousOther != "O"));

            }
        }

        static void switchChannel(int channel)
        {
            if(channel > 31)
            {
                channel = 31;
            }
            if(channel < 1)
            {
                channel = 1;
            }

            currentChannel = channel;

            Console.WriteLine($"Вы переключили канал на {currentChannel}\n");
        }

    }

}
