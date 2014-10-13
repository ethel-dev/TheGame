using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TheGame
{
     
    class Program
    {
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        static IntPtr notepadHandle;
    
        public ConsoleColor currentForegroundColor = Console.ForegroundColor;
        public ConsoleColor currentBackgroundColor = Console.BackgroundColor;
        static void Main(string[] args)
        {
            Console.Write("W");
            Thread.Sleep(100);
            Console.Write("h");
            Thread.Sleep(100);
            Console.Write("a");
            Thread.Sleep(100);
            Console.Write("t");
            Thread.Sleep(100);
            Console.Write("'");
            Thread.Sleep(100);
            Console.Write("s");
            Thread.Sleep(100);
            Console.Write(" i");
            Thread.Sleep(100);
            Console.Write("n");
            Thread.Sleep(100);
            Console.Write(" t");
            Thread.Sleep(100);
            Console.Write("h");
            Thread.Sleep(100);
            Console.Write("e");
            Thread.Sleep(100);
            Console.Write(" B");
            Thread.Sleep(100);
            Console.Write("o");
            Thread.Sleep(100);
            Console.Write("x");
            Thread.Sleep(100);
            Console.Write("?");
            Thread.Sleep(5000);
            Console.WriteLine(" ");
            Console.WriteLine("Press 'X' to find out");
            ConsoleKeyInfo key = Console.ReadKey(intercept: true);
            while (true)
            {
                if (Char.ToLower(key.KeyChar) == 'x')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You did not press X. Please press X.");
                    Console.WriteLine("If you do not want to see what is in the box,");
                    Console.WriteLine("then please exit the program.");
                    Thread.Sleep(5000);
                    Environment.Exit(0);
                }
            }
            Console.Clear();
            Random choose = new Random();
            int chooseaFunction = choose.Next(1, 9);
            int chooseaFunction2 = choose.Next(1, 9);
            int chooseaRandomNumber = choose.Next(1, 3);
            #region Randomizer
            if (chooseaRandomNumber == 1)
            {
                int checkPlease = chooseaFunction;
                if (checkPlease == 1)
                {
                    choice1();
                }
                if (checkPlease == 2)
                {
                    choice2();
                }
                if (checkPlease == 3)
                {
                    choice3();
                }
                if (checkPlease == 4)
                {
                    choice4();
                }
                if (checkPlease == 5)
                {
                    choice5();
                }
                if (checkPlease == 6)
                {
                    choice6();
                }
                if (checkPlease == 7)
                {
                    choice7();
                }
                if (checkPlease == 8)
                {
                    choice8();
                }
            }
            else
            {
                int checkPlease = chooseaFunction2;
                if (checkPlease == 1)
                {
                    choice1();
                }
                if (checkPlease == 2)
                {
                    choice2();
                }
                if (checkPlease == 3)
                {
                    choice3();
                }
                if (checkPlease == 4)
                {
                    choice4();
                }
                if (checkPlease == 5)
                {
                    choice5();
                }
                if (checkPlease == 6)
                {
                    choice6();
                }
                if (checkPlease == 7)
                {
                    choice7();
                }
                if (checkPlease == 8)
                {
                    choice8();
                }
            }
            #endregion


        }
        public static void choice1()
        {
            string userName = Environment.UserName;
            Console.WriteLine("Why did you name your computer '{0}'?", userName);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Tell me about that.");
            Console.WriteLine("a             b              c            d");
            Console.WriteLine("It's my name. I'm at school. I'm at work. I don't know.");
            ConsoleKeyInfo key1 = Console.ReadKey(intercept: true);
            Console.ForegroundColor = ConsoleColor.White;
            #region Choices
            if (char.IsLetter(key1.KeyChar))
            {
                #region A
                if (Char.ToLower(key1.KeyChar) == 'a')
                {
                    Console.WriteLine("{0}: It's my name!", userName);
                    Console.WriteLine("Well then, {0}, what a wonderful name.", userName);
                    Console.WriteLine("If you would like to check the box again, please check back later.");
                    Continue();
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                #endregion
                    #region B
                    if (Char.ToLower(key1.KeyChar) == 'b')
                    {
                        Console.WriteLine("YOU: I'm at school... I can't choose my username.");
                        Console.WriteLine("Oh... well then. What is the name of your school?");
                        string schoolName = Console.ReadLine();
                        Console.WriteLine("Oh! {0}!", schoolName);
                        Console.WriteLine("I've heard great things about the teachers there.");
                        Console.WriteLine("Do you think they are nice?");
                        Console.WriteLine("Press X if you think the teachers are nice. Press anything else if not.");
                        ConsoleKeyInfo yesno = Console.ReadKey(intercept: true);
                        if (Char.ToLower(yesno.KeyChar) == 'x')
                        {
                            Console.WriteLine("YOU: They really are nice.");
                            Console.WriteLine("That's awesome! You are lucky to have nice teachers.");
                            Continue();
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("YOU: My teacher's aren't very nice. How about you?");
                            Thread.Sleep(2000);
                            Console.WriteLine("I don't have any teachers. My creator thinks his teachers are great, though!");
                            Continue();
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                    #endregion
                        #region C
                        if (Char.ToLower(key1.KeyChar) == 'c')
                        {
                            Console.WriteLine("YOU: That's my work username.");
                            Console.WriteLine("Oh. Where do you work?");
                            string workPlace = Console.ReadLine();
                            Random response = new Random();
                            int randomResponse = response.Next(1, 4);
                            if (randomResponse == 1)
                            {
                                Console.WriteLine("Oh. Sadly, I've never heard of {0}.", workPlace);
                                Console.WriteLine("Sorry...");
                                Continue();
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            if (randomResponse == 2)
                            {
                                Console.WriteLine("Oh! {0}!", workPlace);
                                Console.WriteLine("I've heard of that company! It is");
                                Console.WriteLine("very popular in my database.");
                                Continue();
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            if (randomResponse == 3)
                            {
                                Console.WriteLine("{0}!", workPlace);
                                Console.WriteLine("I have a computer friend");
                                Console.WriteLine("who works over there!");
                                Continue();
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            
                        }
                        else
                        {
                        #endregion
                            #region D
                            if (Char.ToLower(key1.KeyChar) == 'd')
                            {
                                Console.WriteLine("Sorry... I can't respond if you can't.");
                                Environment.Exit(0);
                            }
                            else
                            {
                            #endregion
                                Console.WriteLine("You did not press any of the right keys.");
                                Continue();
                                Environment.Exit(0);
                            }
                        }
                    }
                }

            }
            #endregion
            else
            {
                Console.WriteLine("You pressed a number or other unknown key.");
                Continue();
                Console.ReadKey();
            }
        }
        public static void choice2()
        {
            string[] mystrings = "Trinity|Love|Faith|Hope|Disease|Disorder|Disaster|Amazement|Perfection".Split('|');
            Random rnd = new Random();
            string randomWord = mystrings[rnd.Next(mystrings.Length)];
            Console.WriteLine("{0} is in the box. {0}.",randomWord);
            Thread.Sleep(5000);
            Continue();
            Console.ReadKey();
        }
        public static void choice3()
        {
            var p = "3.1415926535 8979323846 2643383279 5028841971 6939937510 5820974944 5923078164 0628620899 8628034825 3421170679 8214808651 3282306647 0938446095 5058223172 5359408128 4811174502 8410270193 8521105559 6446229489 5493038196 4428810975 6659334461 2847564823 3786783165 2712019091 4564856692 3460348610 4543266482 1339360726 0249141273 7245870066 0631558817 4881520920 9628292540 9171536436 7892590360 0113305305 4882046652 1384146951 9415116094 3305727036 5759591953 0921861173 8193261179 3105118548 0744623799 6274956735 1885752724 8912279381 8301194912 9833673362 4406566430 8602139494 6395224737 1907021798 6094370277 0539217176 2931767523 8467481846 7669405132 0005681271 4526356082 7785771342 7577896091 7363717872 1468440901 2249534301 4654958537 1050792279 6892589235 4201995611 2129021960 8640344181 5981362977 4771309960 5187072113 4999999837 2978049951 0597317328 1609631859 5024459455 3469083026 4252230825 3344685035 2619311881 7101000313 7838752886 5875332083 8142061717 7669147303 5982534904 2875546873 1159562863 8823537875 9375195778 1857780532 1712268066 1300192787 6611195909 2164201989";
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 5);
            int randomNumber2 = rnd.Next(5000, 100000000);
            if (randomNumber > 4)
            {
                Console.WriteLine("{0} is in the box.", randomNumber2);
                Continue();
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("This is in the box: {0}", p);
                Thread.Sleep(1000);
                Console.Clear();
                Continue();
                Console.ReadKey();
            }
        }
        public static void choice4()
        {
            string path = Directory.GetCurrentDirectory();
            // Example #1: Write an array of strings to a file. 
            // Create a string array that consists of three lines. 
            string[] lines = { "What's", "in", "the Box?" };
            // WriteAllLines creates a file, writes a collection of strings to the file, 
            // and then closes the file.
            System.IO.File.WriteAllLines(path + "/whatsinthebox.txt", lines);
            System.Diagnostics.Process.Start(path + "/whatsinthebox.txt");
        }
        public static void choice5()
        {
            System.Diagnostics.Process.Start("https://dl.dropboxusercontent.com/u/66449290/website.html");
        }
        #region NotepadWriter
        public static void choice6()
        {
            Process notepad = new Process();
            notepad.StartInfo.FileName = "notepad.exe";
            notepad.Start();
            notepad.WaitForInputIdle();
            notepadHandle = notepad.MainWindowHandle;

            WriteLineToNotePad("NOTE TO SELF: Put something cool and clever in the Box.");
            SendKeyStroke(Environment.NewLine);
            SendKeyStroke(Environment.NewLine);
            WriteLineToNotePad("Wait...");
            Thread.Sleep(5000);
            notepad.Kill();
        }
        public static void SendKeyStroke(string KeyStroke)
        {
            SetForegroundWindow(notepadHandle); //Make sure Notepad is the top window
            SendKeys.SendWait(KeyStroke); //And send a keystroke
        }
        static void WriteLineToNotePad(string line)
        {
            for (int i = 0; i < line.Length; i++)
            {//for every letter
                Thread.Sleep(50); //wait a bit
                SendKeyStroke(line[i].ToString()); //then send the keystroke
            }
        }


        #endregion
        public static void choice7()
        {
            System.Diagnostics.Process.Start("https://db.tt/DLLMT6vN");
        }
        public static void choice8()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("|    NOTHING IS   |");
            Console.WriteLine("|   IN THE BOX    |");
            Console.WriteLine("-------------------");
            Console.Beep(100, 200);
            Console.Beep(50, 500);
            Continue();
        }
        public static void choice9()
        {

        }
        public static void Continue()
        {
            Console.Write("P");
            Thread.Sleep(50);
            Console.Write("r");
            Thread.Sleep(50);
            Console.Write("e");
            Thread.Sleep(50);
            Console.Write("s");
            Thread.Sleep(50);
            Console.Write("s");
            Thread.Sleep(50);
            Console.Write(" ");
            Thread.Sleep(50);
            Console.Write("a");
            Thread.Sleep(50);
            Console.Write("n");
            Thread.Sleep(50);
            Console.Write("y");
            Thread.Sleep(50);
            Console.Write(" ");
            Thread.Sleep(50);
            Console.Write("k");
            Thread.Sleep(50);
            Console.Write("e");
            Thread.Sleep(50);
            Console.Write("y");
            Thread.Sleep(50);
            Console.Write(" ");
            Thread.Sleep(50);
            Console.Write("t");
            Thread.Sleep(50);
            Console.Write("o");
            Thread.Sleep(50);
            Console.Write(" ");
            Thread.Sleep(50);
            Console.Write("c");
            Thread.Sleep(50);
            Console.Write("o");
            Thread.Sleep(50);
            Console.Write("n");
            Thread.Sleep(50);
            Console.Write("t");
            Thread.Sleep(50);
            Console.Write("i");
            Thread.Sleep(50);
            Console.Write("n");
            Thread.Sleep(50);
            Console.Write("u");
            Thread.Sleep(50);
            Console.Write("e");
            Thread.Sleep(50);
            Console.Write(".");
            Thread.Sleep(50);
            Console.Write(".");
            Thread.Sleep(50);
            Console.Write(".");
            Thread.Sleep(50);

        }

    }
}
