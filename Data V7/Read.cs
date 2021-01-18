using System;

namespace Data_V7
{
    public class Read
    { 
        private static ConsoleKeyInfo key;
        public static char ReadChar()
        {
            string theChar = "";
            do
                {
                    key = Console.ReadKey(true);
                    if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                    {

                        if (theChar.Length < 1)
                        {
                            theChar = key.KeyChar.ToString();
                            Console.Write(key.KeyChar);
                        }
                    }
                    else
                    {
                        if (key.Key == ConsoleKey.Backspace && theChar.Length > 0)
                        {
                            theChar = theChar.Substring(0, (theChar.Length - 1));
                            Console.Write("\b \b");
                        }
                    }
                }
                // Stops Receving Keys Once Enter is Pressed
                while (key.Key != ConsoleKey.Enter);
                return theChar[0];
        }
        public static char ReadChar(string c)
        {
            string theChar = "";
            do
                {
                    key = Console.ReadKey(true);
                    if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                    {

                        if (theChar.Length < 1 && c.Contains(key.KeyChar))
                        {
                            theChar = key.KeyChar.ToString();
                            Console.Write(key.KeyChar);
                        }
                    }
                    else
                    {
                        if (key.Key == ConsoleKey.Backspace && theChar.Length > 0)
                        {
                            theChar = theChar.Substring(0, (theChar.Length - 1));
                            Console.Write("\b \b");
                        }
                    }
                }
                // Stops Receving Keys Once Enter is Pressed
                while (key.Key != ConsoleKey.Enter);
                return theChar[0];
        }
        public static string ReadString()
        {
            string str = "";
            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace)
                {
                    if(key.Key != ConsoleKey.Enter)
                    {
                        str += key.KeyChar;
                        Console.Write(key.KeyChar);
                    }
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && str.Length > 0)
                    {
                        str = str.Substring(0, (str.Length - 1));
                        Console.Write("\b \b");
                    }
                }
            }while (key.Key != ConsoleKey.Enter);
            return str;
        }
        public static string ReadString(string symbol)
        {
            string str = "";
            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace)
                {
                    if(key.Key != ConsoleKey.Enter)
                    {
                        str += key.KeyChar;
                        Console.Write(symbol);
                    }
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && str.Length > 0)
                    {
                        str = str.Substring(0, (str.Length - 1));
                        Console.Write("\b \b");
                    }
                }
            }while (key.Key != ConsoleKey.Enter);
            return str;
        }
        public static int ReadInt()
        {
            string number = "";
            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace)
                {
                    double val = 0;
                    bool _x = double.TryParse(key.KeyChar.ToString(), out val);
                    if (_x)
                    {
                        number += key.KeyChar;
                        Console.Write(key.KeyChar);
                    }
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && number.Length > 0)
                    {
                        number = number.Substring(0, (number.Length - 1));
                        Console.Write("\b \b");
                    }
                }
            }while (key.Key != ConsoleKey.Enter);
            return Convert.ToInt32(number);
        }
        public static long ReadLong()
        {
            string number = "";
            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace)
                {
                    double val = 0;
                    bool _x = double.TryParse(key.KeyChar.ToString(), out val);
                    if (_x)
                    {
                        number += key.KeyChar;
                        Console.Write(key.KeyChar);
                    }
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && number.Length > 0)
                    {
                        number = number.Substring(0, (number.Length - 1));
                        Console.Write("\b \b");
                    }
                }
            }while (key.Key != ConsoleKey.Enter);
            return (long)Convert.ToDouble(number);
        }
        public static decimal ReadDecimal()
        {
            string @decimal = "";
            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace)
                {
                    if(!@decimal.Contains(".")){
                        double val = 0;
                        bool _x = double.TryParse(key.KeyChar.ToString(), out val);
                        if (_x)
                        {
                            @decimal += key.KeyChar;
                            Console.Write(key.KeyChar);
                        }
                    }else if(@decimal.Contains("."))
                    {
                        string[] dec = @decimal.Split(".");
                        if(dec[1].Length < 2)
                        {
                            @decimal += key.KeyChar;
                            Console.Write(key.KeyChar);
                        }
                    }
                    if(key.KeyChar == '.' && !@decimal.Contains("."))
                    {
                        @decimal += key.KeyChar;
                        Console.Write(key.KeyChar);
                    }

                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && @decimal.Length > 0)
                    {
                        @decimal = @decimal.Substring(0, (@decimal.Length - 1));
                        Console.Write("\b \b");
                    }
                }
            }while (key.Key != ConsoleKey.Enter);
            return Convert.ToDecimal(@decimal);
        }
    }
 }