using System;
using System.Xml.Serialization;
using static System.Console;
namespace LogoGost
{
    class Program
    {//ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
     //BackgroundColor = ConsoleColor.White;
     //ResetColor();
        delegate void Logo();
        
        

        public static void Point(char symbol, string x, int quantity)
        {

            switch (symbol)
            {
                case 'b':
                    ForegroundColor = ConsoleColor.Blue;
                    break;
                case 'd':
                    ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case 'p':
                    ForegroundColor = ConsoleColor.Magenta;
                    break;
                case 'g':
                    ForegroundColor = ConsoleColor.Gray;
                    break;
                case 'w':
                    ForegroundColor = ConsoleColor.White;
                    break;
                case 'r':
                    ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case 'R':
                    ForegroundColor = ConsoleColor.DarkRed;
                    break;
                default:
                    break;
            }
            for (int i = 0; i < quantity; i++)
            {
                Write(x);
            }
            ResetColor();
        }
       public static void DarckRed(int quant) { ForegroundColor = ConsoleColor.Black; BackgroundColor = ConsoleColor.DarkRed; for (int i = 0; i < quant; i++)
            {
                Write("▓");
            }
            ResetColor();
        }
       
        public static void DarckRed2(int quant)  { Point('r', "▓", quant);}
        public static void DarckRed()
        {
            ForegroundColor = ConsoleColor.Black; BackgroundColor = ConsoleColor.DarkRed; for (int i = 0; i < 1; i++)
            {
                Write("▓");
            }
            ResetColor();
        }
        public static void Red(int quant) { Point('r', "█", quant); }
       
        public static void Blue(int quant) { Point('b', "█", quant); }
        public static void Blue() { Point('b', "█", 1); }
        public static void DarckBlue(int quant) { Point('d', "▒", quant); }
        public static void Pink(int quant) { Point('p', "▒", quant); }
        public static void Gray(int quant) { Point('g', "▒", quant); }
        public static void White(int quant) { Point('w', "█", quant); }
        public static void Black(int quant) { Point(' ', " ", quant); }
        public static void Red() { Point('r', "█", 1); }
        
        public static void DarckBlue() { Point('d', "▒", 1); }
        public static void Pink() { Point('p', "▒", 1); }
        public static void Gray() { Point('g', "▒", 1); }
        public static void White() { Point('w', "█", 1); }
        public static void Black() { Point(' ', " ", 1); }
        public static void DarckRed2() { Point('r', "▓", 1); }
        static void Main(string[] args)
        {
            Logo logo;      
           
            void line_1()
            {
                ForegroundColor = ConsoleColor.Blue;
                string x = "█";
                string y = " ";
                Write($"   {x+x+x}  {x + x + x}  {x + x + x}");
                for (int i = 0; i < 9; i++)
                {
                    Write(" ");
                }
                Point('w', x, 1);
                Point(' ',y, 12);
                Point('w', x, 2);
                Point(' ', y, 10);
                ForegroundColor = ConsoleColor.Blue;
                Write($"{x + x + x}  {x + x + x}  {x + x + x}      ");
                ResetColor();
                WriteLine();
            }
            
            void line_2() {
                line_1();
                string x = "█";
                string y = " ";
                string z = "▒";
                Point('g', z, 3);
                ForegroundColor = ConsoleColor.Blue;
                Write($"{x + y + x}  {x}");
                ForegroundColor = ConsoleColor.DarkBlue;
                Write(z);
                ForegroundColor = ConsoleColor.Blue;
                Write($"{x}  {x}");
                ForegroundColor = ConsoleColor.Magenta;
                Write(z);
                ForegroundColor = ConsoleColor.Blue;
                Write(x);
                for (int i = 0; i < 5; i++)
                {
                    Write(" ");
                }
                Point('g', z, 2);
                Point('w', x, 3);
                Point(' ', y, 5);
                Point('g', z, 5);
                Point(' ', y, 2);
                Point('w', x, 3);
                Point('g', z, 5);
                Point(' ', y, 4);
                ForegroundColor = ConsoleColor.Blue;
                Write($"{x + y + x}  {x}");
                ForegroundColor = ConsoleColor.DarkBlue;
                Write(z);
                ForegroundColor = ConsoleColor.Blue;
                Write($"{x}  {x}");
                ForegroundColor = ConsoleColor.Magenta;
                Write(z);
                ForegroundColor = ConsoleColor.Blue;
                Write(x);
                Point('g', z, 4);
                ResetColor();
                WriteLine();
            }
            void line_3()
            {
                line_2();
                string x = "█";
                string y = " ";
                string z = "▒";
                ForegroundColor = ConsoleColor.Blue;
                Write($"   {x + y + x + x + x + x}");
                ForegroundColor = ConsoleColor.DarkBlue;
                Write(z);
                ForegroundColor = ConsoleColor.Blue;
                Write($"{x+x+x+x}");
                ForegroundColor = ConsoleColor.Magenta;
                Write(z);
                ForegroundColor = ConsoleColor.Blue;
                Write(x);
                Point('g', z, 5);
                Write(" ");
                Point('w', x, 2);
                Write("  ");
                Point('g', z, 5);
                Point(' ', y, 5);
                Point('g', z, 1);
                Point('w', x, 2);
                Point('g', z, 1);
                Point('w', x, 3);
                Point(' ', y, 3);
                Point('g', z, 4);
                ForegroundColor = ConsoleColor.Blue;
                Write($"{x + y + x + x + x + x}");
                ForegroundColor = ConsoleColor.DarkBlue;
                Write(z);
                ForegroundColor = ConsoleColor.Blue;
                Write($"{x + x + x + x}");
                ForegroundColor = ConsoleColor.Magenta;
                Write(z);
                ForegroundColor = ConsoleColor.Blue;
                Write(x + "    ");
                Point('g', z, 2);
                ResetColor();
                WriteLine();
            }
            void line_4()
            {
                line_3();
                string x = "█";
                string y = " ";
                string z = "▒";
                Point('g', z, 3);
                ForegroundColor = ConsoleColor.Blue;
                Write($"{x + y + y}"); 
                ForegroundColor = ConsoleColor.DarkBlue;
                Write(z+z+z+z+z+z+z+z);                
                ForegroundColor = ConsoleColor.Magenta;
                Write(z);
                ForegroundColor = ConsoleColor.Blue;
                Write(x);
                for (int i = 0; i < 5; i++)
                {
                    Write(" ");
                }
                Point('g', z, 1);
                Point('w', x, 3);
                Point('g', z, 1);
                Point(' ', y, 5);
                Gray(5);
                White(3);
                Black(2);
                Gray(1);
                White(4);
                Black(4);
                ForegroundColor = ConsoleColor.Blue;
                Write($"{x + y + y}");
                ForegroundColor = ConsoleColor.DarkBlue;
                Write(z + z + z + z + z + z + z + z);
                ForegroundColor = ConsoleColor.Magenta;
                Write(z);
                ForegroundColor = ConsoleColor.Blue;
                Write(x);
                Gray(4);
                Black(2);
                ResetColor();
                WriteLine();
            }

            void line_5()
            {
                line_4();
                string x = "█";
                string y = " ";
                string z = "▒";
                Write("   ");
                Point('b', x, 1);
                Write("   ");
                Point('d', z, 6);
                Point('p', z, 2);
                Point('b', x, 1);
                Gray(4);
                White(3);
                Black();
                White();
                Black();
                Gray(5);
                Black(4);
                White(2);
                Gray();
                White();
                Gray(2);
                Black(4);
                White(2);
                Gray(3);

                Point('b', x, 1);
                Write("   ");
                Point('d', z, 6);
                Point('p', z, 2);
                Point('b', x, 1);
                Write("    ");
                Gray(2);
                ResetColor();
                WriteLine();
            }

            void line_6()
            {
                line_5();
                string x = "█";
                string y = " ";
                string z = "▒";
                Gray(3);
                Point('b', x, 3);
                Write("  ");
                Point('d', z, 4);
                Point('p', z, 1);
                Point('b', x, 3);
                Point(' ', y,4);
                White();
                Gray(3);
                White(2);
                Black(5);
                Gray(4);
                White();
                Black(2);
                White(2);
                Black();
                Gray(5);
                White();
                Black(3);
                Point('b', x, 3);
                Write("  ");
                Point('d', z, 4);
                Point('p', z, 1);
                Point('b', x, 3);
                Gray(4);
                ResetColor();
                WriteLine();
            }
            void line_7()
            {
                line_6();
                string x = "█";
                string y = " ";
                string z = "▒";
                Point(' ', y, 4);
                Gray();
                Point('b', x, 1);
                Write("  ");
                Point('d', z, 4);
                Point('p', z, 1);
                Point('b', x, 1);
                Point(' ', y, 2);
                Gray(3);
                Point('b', x, 6);
                White();
                Gray(4);
                Point('b', x, 6);
                Gray(3);White();Gray();
                Point('b', x, 6);
                White();Gray(2);Black(2);
                Point('b', x, 1);
                Write("  ");
                Point('d', z, 4);
                Point('p', z, 1);
                Point('b', x, 1);
                Gray(2);Black(4);Gray(2);
                ResetColor();
                WriteLine();
            }
            void line_8()
            {
                line_7();
                Gray(4);Black();Blue();Black(2);DarckBlue(4);Pink();Blue();
                Gray(2);Black(3);
                Blue();DarckBlue(2);Pink(2);Blue();
                White();Black(4);
                Blue();DarckBlue(2); Pink(2); Blue();
                Black(3); White(2);
                Blue();DarckBlue(2); Pink(2); Blue();
                Black(3);Gray(2);
                Blue(); Black(2); DarckBlue(4); Pink(); Blue();
                Black(2);Gray(4);
                ResetColor();
                WriteLine();
            }
            void line_9() {
                line_8();
                Black(4);Gray();
                Blue(); Black(2); DarckBlue(4); Pink(); Blue();
                Black(2);Gray(3);
                Blue();Black();DarckBlue(2);Pink();Blue();
                White(2);Gray(3);
                Blue(); Black(); DarckBlue(2); Pink(); Blue();
                Gray(4);White();
                Blue(); Black(); DarckBlue(2); Pink(); Blue();
                Gray(3);Black(2);
                Blue(); Black(2); DarckBlue(4); Pink(); Blue();
                Gray(2);Black(4);Gray(2);
                ResetColor();
                WriteLine();
            }
            void line_10()
            {
                line_9();
                Black(2);
                Blue(14);
                Red(7);
                Blue(2);
                Red();
                Blue(4);
                Red();
                Blue(2);
                Red(6);
                Blue(2);
                Red(6);
                Blue(2);
                Red(7);
                Blue(13);

                ResetColor();
                WriteLine();
            }
            void line_11()
            {
                line_10();
                Black(2);Blue();Black();DarckBlue(5);Blue();Black();DarckBlue(4);DarckRed();Red();DarckRed(5);DarckBlue();Blue();DarckRed();Red();DarckBlue(3);DarckRed();Red();Black();
                DarckRed();Red();DarckRed(4);Red();Blue(); DarckRed(); Red();DarckRed(5);Blue();DarckRed(4);Red();DarckRed(2);Black();DarckBlue(3);Pink(2);Blue(); Black(); DarckBlue(3); Pink(2); Blue();


                ResetColor();
                WriteLine();
            }
            void line_12()
            {
                line_11();
                Black(2);Blue();Black(2);DarckBlue(4);Blue();Black(2); DarckBlue(3);DarckRed();Red();Black();DarckBlue(5);Blue();DarckRed();Red();DarckBlue(3); DarckRed(); Red();
                Black(); DarckRed(); Red();Blue();Pink(2); DarckRed(); Red(); Blue(); DarckRed(); Red(); Black(); DarckBlue(3);Pink();Blue();Black(2);DarckBlue(); DarckRed(); Red();DarckBlue();
                Blue(); Black(2); DarckBlue(3);Pink(); Blue(); Black(2); DarckBlue(3); Pink();Blue();

                ResetColor();
                WriteLine();
            }

            void line_13()
            {
                line_12();
                Black(2); Blue(); Black(3);DarckBlue(3);Blue();Black(3);DarckBlue(2); DarckRed(); Red();Black(2);DarckBlue(4);Blue(); DarckRed(); Red();Black();DarckBlue(2); DarckRed(); Red();Black();
                DarckRed(); Red();DarckBlue(2);Pink(); DarckRed(); Red();Blue(); DarckRed(); Red();Black(2); DarckBlue(2);Pink();Blue();Black(3); DarckRed(); Red();DarckBlue();Blue();Black(3);DarckBlue(2);Pink(); Blue(); Black(3); DarckBlue(2); Pink(); Blue();
                ResetColor();
                WriteLine();
            }
            void line_14() {
                line_13();
                Black(2); Blue(13); DarckRed(); Red(); Blue(7); DarckRed(); Red(6); Blue(); DarckRed(); Red(); Blue(3); 
                DarckRed(); Red(); Blue(); DarckRed(); Red(6); Blue(4); DarckRed(); Red(); Blue(16);
                ResetColor();
                WriteLine();
            }

            void line_15()
            {
                line_14();
                Black(4); Blue(); Black(); DarckBlue(5); Blue(); Black(); DarckBlue(2); DarckRed(); Red(); Black(); Blue(); Black();
                Red(3); DarckBlue(); DarckRed(); Red(); DarckRed(4); Red(); DarckBlue(); DarckRed(); Red(); Blue(); Black();
                DarckBlue(); DarckRed(); Red(); DarckBlue();  DarckRed(6); Red(); DarckBlue(2); Blue(); Black();
                DarckRed(); Red(); DarckBlue(2); Blue(); Black(); DarckBlue(2); Pink(2); Blue();
                ResetColor();
                WriteLine();
            }

                void line_16()
            {
                line_15();
                Black(4); Blue(); Black(2); DarckBlue(4); Blue(); Black(2); DarckBlue(); DarckRed(); Red(); Black(); 
                Blue();Black(); DarckRed(2); Red(); DarckBlue(); DarckRed(); Red(); Blue(); Black(); DarckBlue(); DarckRed(); 
                Red(); DarckBlue(); DarckRed(); Red(); Blue(); Black(2); DarckRed(); Red(); DarckBlue(2); Blue(); Black(); 
                DarckBlue(2); DarckRed(); Red(); DarckBlue(2); Blue(); Black(); DarckRed(); Red(); DarckBlue(2); Blue(); Black(2); DarckBlue(2); Pink(); Blue();
                ResetColor();
                WriteLine();
            }

            void line_17()
            {
                line_16();
                Black(4); Blue(); Black(3); DarckBlue(3); Blue(); Black(3); DarckRed(); Red(); Black(); Blue(); Black(2); DarckRed(); Red(); DarckBlue(); DarckRed(); Red(); Blue(); Black(2); 
                DarckRed(); Red(); DarckBlue(); DarckRed(); Red(); Blue(); Black(2); DarckRed(); Red(); DarckBlue(2); Blue(); Black(2); DarckBlue(); 
                DarckRed(); Red(); DarckBlue(2); Blue(); Black();DarckRed();Red(); DarckBlue(2); Blue();
                ResetColor();
                WriteLine();
            }

            void line_18()
            {
                line_17();
                Blue(15); DarckRed(); Red(7); Blue(); DarckRed(); Red(); Blue(3); DarckRed(); Red(); Blue(); DarckRed(); Red(6); Blue(2); Red(6); Blue(4); DarckRed(); Red(); Blue(13);
                ResetColor();
                WriteLine();
            }

            void line_19()
            {
                line_18();
                Blue(); Black(); DarckBlue(4); Blue(); Black(); DarckBlue(5); Blue(); Black(); DarckRed(7); DarckBlue(2); DarckRed(); DarckBlue(2); Blue(); DarckBlue(); DarckRed(); DarckBlue(2);
                DarckRed(6); DarckBlue(2); DarckRed(6); DarckBlue(); Blue(); Black(); DarckBlue(2); DarckRed(); DarckBlue(2); Blue(); Black(); DarckBlue(); Pink(2); Blue(); Black(); DarckBlue(2); Pink(2); Blue();
                ResetColor();
                WriteLine();
            }

            void line_20()
            {
                line_19();
                Blue(); Black(2); DarckBlue(3); Blue(); Black(2); DarckBlue(4); Blue(); Black(2); DarckBlue(4); Blue(); Black(2); DarckBlue(4); Blue(); Black(2); DarckBlue(4); Blue(); Black(2); DarckBlue(4); 
                Blue(); Black(3); DarckBlue(2); Blue(); Black(2); DarckBlue(4); Blue(); Black(2); DarckBlue(); Pink(); Blue(); Black(2); DarckBlue(2); Pink(); Blue();
                ResetColor();
                WriteLine();
            }

            void line_21()
            {
                line_20();
                Blue(); Black(3); DarckBlue(2); Blue(); Black(3); Red();  DarckBlue(2); Blue(); Black(); Red(); Black(); DarckBlue(); Red(); DarckBlue(); Blue(); Black(2); Red(); DarckBlue(2); Red(); 
                Blue(); Black(3); Red(); DarckBlue(); Red(7); DarckBlue(); Red(6); Blue(); Black(); Red(5); Blue(); Black(3); Pink(); Blue(); Black(3); DarckBlue(); Pink(); Blue();
                ResetColor();
                WriteLine();
            }

            void line_22()
            {
                line_21();
                Blue(9); DarckRed(); Red(); Blue(3); DarckRed(); Red(); Blue(); DarckRed(); Red(); Blue(3); DarckRed(); Red(); Blue(); DarckRed(); Red(); DarckRed2()/*&*/; Blue(2); DarckRed(); Red(); DarckRed(4); 
                Red(); Blue(3); DarckRed(); Red(); DarckRed(4); Blue(2); DarckRed(); Red(); DarckRed(4); Red(2); Blue(10);
                ResetColor();
                WriteLine();
            }

            void line_23()
            {
                line_22();
                Black(7); Blue(); Black(); DarckRed(); Red(); DarckBlue(3); DarckRed(); Red(); Black(); DarckRed(); Red(); DarckBlue(2); Blue(); DarckRed(); Red(); DarckBlue(); DarckRed(); Red(2); 
                Black(); DarckBlue(); DarckRed(); Red(); DarckBlue(); Blue(); Black(); DarckRed(); Red(); DarckBlue(2); Blue(); DarckRed(); 
                Red(); DarckBlue(); Blue(); DarckBlue(3); Black(); DarckRed(); Red(); Black(); Blue(); DarckBlue(2); DarckRed(); Red(); Black(); DarckBlue(4); Pink(2); Blue();
                ResetColor();
                WriteLine();
            }
            void line_24()
            {
                line_23();
                Black(7); Blue(); Black(); DarckRed(); Red(); DarckBlue(3); DarckRed(); Red(); Black(); DarckRed(); Red(); DarckBlue(2); Blue(); DarckRed(); Red(); DarckBlue(); DarckRed(); Red();
                DarckRed2(2); /*&*/; DarckBlue(); DarckRed(); Red(); DarckBlue(); Blue(); Black(); DarckRed(); Red(); DarckBlue(2); Blue(); DarckRed(); Red(); DarckBlue(); Blue(); Black(2); DarckBlue(2); 
                DarckRed(); Red(); Black(); Blue(); Black(); DarckBlue(); DarckRed(); Red(); Black(2); DarckBlue(4); Pink(); Blue();
                ResetColor();
                WriteLine();
            }

            void line_25()
            {
                line_24();
                Black(7); Blue(); Black(); DarckRed(); Red(); Black(); DarckBlue(2); DarckRed(); Red(); Black(); DarckRed(); Red(); Black(); DarckBlue(); Blue(); DarckRed(); Red(); Black(); DarckRed(); 
                Red(); DarckRed(); Red(); Black(); DarckRed(); Red(); DarckBlue(); Blue(); Black(); DarckRed(); Red(); Black(); DarckBlue(); Blue(); DarckRed(); Red(4); Black(2); DarckBlue(); DarckRed(); 
                Red();Black();Blue();Black(2); DarckRed(); Red(); Black(3); DarckBlue(3); Pink(); Blue();
                ResetColor();
                WriteLine();
            }
            void line_26()
            {  line_25();
                Black(5); Blue(4);DarckRed();Red(6);Blue(); DarckRed(); Red();Blue(3); DarckRed(); Red();Blue(); DarckRed(); Red();DarckRed();DarckRed2(2); DarckRed(); Red();Blue(3); DarckRed(); Red();Blue(3); DarckRed(); 
                Red();DarckRed(2);Blue(4); DarckRed(); Red(7);Blue(8);
                ResetColor();
                WriteLine();
            }
            void line_27()
            {
                line_26();
                Black(5); Blue(); DarckBlue(3); DarckRed(); Red(); DarckRed(4); Red(); Black(); DarckRed(); Red(); DarckBlue(2); Blue(); DarckRed(); Red(); DarckBlue(); DarckRed(); Red();
                DarckBlue(); DarckRed(); Red(); DarckRed(); Red(); DarckBlue(2); Blue(); DarckRed(); Red(); DarckBlue(2); Blue(); DarckRed(); Red(); DarckBlue(2); Blue(); DarckBlue(3); DarckRed(); Red();
                DarckRed(); Red(); DarckRed2(); DarckBlue(3); Blue(); DarckBlue(2); Pink(2); Blue();
                ResetColor();
                WriteLine();
            }
            void line_28()
            {
                line_27();
                Black(5);Blue();Black();DarckBlue(2); DarckRed(); Red();Blue();DarckBlue(2); DarckRed(); Red();Black(); DarckRed(); Red();DarckBlue(2);Blue(); DarckRed(); Red();DarckBlue(); DarckRed(); Red();
                DarckBlue();DarckRed();DarckRed2(2);Red(); DarckBlue(2); Blue(); DarckRed(); Red(); DarckBlue(2); Blue(); DarckRed(); Red();Black(); DarckBlue();Blue();Black(); DarckBlue(2); DarckRed(); Red();
                Black(); DarckRed(); Red();DarckRed2();DarckBlue(2); Blue();Black();DarckBlue(2);Pink(); Blue();
                ResetColor();
                WriteLine();
            }
            void line_29()
            {
                line_27();
                Black(5);Blue();Black(2);DarckBlue(); DarckRed(); Red();Blue();Black();DarckBlue(); DarckRed(); Red();Black(); DarckRed(); Red();Black();DarckBlue();Blue(); DarckRed(); Red(); Black(); DarckRed(); Red();
                DarckBlue();DarckRed(2);Red(2);Black();DarckBlue();Blue(); DarckRed(); Red(); Black(); DarckBlue(); Blue(); DarckRed(); Red();Black(2);Blue();Black(2);DarckBlue(); DarckRed(); Red();
                Black(2); DarckRed(); Red();DarckRed2();DarckBlue();Blue();Black(2);DarckBlue();Pink();Blue();
                ResetColor();
                WriteLine();
            }
            void line_30()
            {
                line_29();
                Black(5);Blue();Black(3); DarckRed(); Red();Blue();Black();DarckBlue(); DarckRed(); Red();Black(); DarckRed(); Red();Black();DarckBlue();Blue(); DarckRed(); Red();Black(); DarckRed(); Red();
                DarckBlue();Blue(); DarckRed(); DarckRed2();Red();Black();DarckBlue();Blue(); DarckRed(); Red(); Black(); DarckBlue(); Blue(); DarckRed(); Red();Black(2);Blue();Black(3); DarckRed(); Red();
                Black(3); DarckRed(); Red();DarckRed2();Blue();Black(3);Pink();Blue();
                ResetColor();
                WriteLine();
            }
            void line_31()
            {
                line_30();
                Black(5);Blue(4); DarckRed(); Red();Blue(3); DarckRed(); Red();Blue(); DarckRed(); Red(6);Blue(); DarckRed(); Red();Blue(3); DarckRed(); Red();  Blue(3); DarckRed(); Red();Blue(3);
                DarckRed(); Red(6);Blue(); DarckRed(); Red();Blue(4); DarckRed(); Red();Blue(6);
                ResetColor();
                WriteLine();
            }
            void line_32()
            {
                line_31();
                Black(9);DarckRed(); Black(4);DarckRed(); Black(2);DarckRed(6);Black(2);DarckRed(2);Black(3);DarckRed(2);Black(3);DarckRed();Black(4);DarckRed(6);Black(2);DarckRed();Black(6);DarckRed();Black();
                ResetColor();
                Black();
                WriteLine("\n");
            }

            void line_33()
            {
                line_32();
                Black(45);Gray(10); WriteLine();
                Black(45);Gray();Black(8);Gray(); WriteLine();
                Black(43);Gray(3);Black(8);Gray(3); WriteLine();
                Black(43);Gray();Black(12);Gray(); WriteLine();
                Black(41); Gray(3); Black(2); Gray(); Black(6);Gray();Black(2);Gray(3); WriteLine();
                Black(41);Gray();Black(3);Gray();Black();Gray();Black(4);Gray();Black();Gray();Black(3); Gray(); WriteLine();
                Black(41);Gray(); Black(2); Gray(); Black(3);Gray();Black(2);Gray();Black(3);Gray(); Black(2);Gray(); WriteLine();
                Black(41); Gray(); Black(3); Gray(); Black(1); Gray(); Black(4); Gray(); Black(1); Gray(); Black(3);Gray(); WriteLine();
                Black(41); Gray(); Black(4); Gray(); Black(6); Gray(); Black(4); Gray();  WriteLine();
                Black(41); Gray(); Black(16); Gray(); WriteLine();
                Black(41); Gray(); Black(16); Gray(); WriteLine();
                Black(41); Gray(); Black(7); Gray(3); Black(6);Gray(); WriteLine();
                Black(41); Gray(); Black(6);Gray();Black(3);Gray();Black(5);Gray(); WriteLine();
                Black(41); Gray(); Black(5);Gray();Black(5);Gray();Black(4);Gray(); WriteLine();
                Black(41); Gray(); Black(16); Gray(); WriteLine(); Black(41); Gray(); Black(16); Gray(); WriteLine(); Black(41); Gray(); Black(16); Gray(); WriteLine();
                Black(41); Gray(); Black(3); Gray(14); WriteLine();
                Black(41); Gray(); Black(3); Gray(14); WriteLine();
                for (int i = 0; i < 2; i++)
                {
                    Black(41); Gray(5); Black(); Gray(2); Black(2); Gray(2); Black(); Gray(); Black(2); Gray(2); WriteLine();
                }
                for (int i = 0; i < 3; i++)
                {
                    Black(41); Gray(2); Black();Gray(2); Black(); Gray(2); Black(2); Gray(2); Black(); Gray(); Black(2); Gray(2); WriteLine();
                }
                for (int i = 0; i < 2; i++)
                {
                    Black(41); Gray(2); Black(4);  Gray(2); Black(2); Gray(2); Black(1); Gray(1);Black(2);Gray(2); WriteLine();
                }
                for (int i = 0; i < 2; i++)
                {
                    Black(41); Gray(2); Black(4); Gray(2); Black(5); Gray(1); Black(2); Gray(2); WriteLine();
                }
                Black(47); Gray(2); Black(8); Gray(2); WriteLine(); Black(47); Gray(2); Black(8); Gray(2); WriteLine(); Black(47); Gray(2); Black(8); Gray(2); WriteLine();
                Black(47); Gray(2); Black(8); Gray(1); WriteLine(); Black(47); Gray(2); Black(8); Gray(2); WriteLine(); Black(47); Gray(2); Black(8); Gray(2); WriteLine(); Black(47); Gray(2); Black(8); Gray(2); WriteLine();
                Black(57);Gray(); WriteLine(); Black(57); Gray(); WriteLine(); Black(57); Gray(); WriteLine(); Black(57); Gray(); WriteLine(); Black(57); Gray(); WriteLine();
                ResetColor();
                WriteLine();

            }
           
            line_33();
            }
    }
}
