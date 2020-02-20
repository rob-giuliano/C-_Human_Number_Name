
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Human_Number_Name
{
    class Human_Number_Name
    {
        static void Main(string[] args)
        {
            HumanName run = new HumanName();
            run.Run();
            Console.ReadKey();
        }
    }
    class HumanName
    {
        string varName;
        public void Run()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Insert your Name: ");
            Console.WriteLine("");
            varName = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("");
            this.Human_Number_Name(varName);
        }
        public void Human_Number_Name(string varName)
        {
            int _pytha_number = 0;
            int _chalde_number = 0;
            int _divine_number = 0;
            int _jewish_number = 0;
            int _greek_number = 0;
            foreach (char x in varName)
            {
                _pytha_number += this._pytha(x);
                _chalde_number += this._chalde(x);
                _divine_number += this._divine(x);
                _jewish_number += this._jewish(x);
                _greek_number += this._greek(x);
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("  === Your Real Numbers === ");
            Console.WriteLine("  ----------------------------");
            Console.WriteLine("  Pythagora Numerology: ==> " + _pytha_number);
            Console.WriteLine("  Chaldean  Numerology: ==> " + _chalde_number);
            Console.WriteLine("  Divine Numbers:       ==> " + _divine_number);
            Console.WriteLine("  Gematria Jewish:      ==> " + _jewish_number);
            Console.WriteLine("  Stoicheia Greek:      ==> " + _greek_number);
            Console.WriteLine(" ===============================");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" ==> Another name or phrases? ");
            Console.WriteLine("     -------------------------");
            Console.WriteLine("");
            Console.WriteLine("==> Ok, check: ");
            Console.WriteLine("");
            varName = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("");
            this.Human_Number_Name(varName);   
        }

    public int _pytha(char x)
        {
            string _pytha_reckon;
            _pytha_reckon = x.ToString().ToUpper();
            Dictionary<String, int> Pythagorean = new Dictionary<String, int>()
            {
            {"A",1}, {"B", 2}, {"C",3}, {"D",4}, {"E", 5}, {"F",6}, {"G",7}, {"H",8}, {"I",9}, {"J",1}, {"K", 2}, {"L",3}, {"M",4}, {"N", 5},
            {"O",6}, {"P",7}, {"Q", 8}, {"R",9}, {"S",1}, {"T", 2}, {"U",3}, {"V",4}, {"W", 5}, {"X",6}, {"Y",7}, {"Z", 8}, {" ",0}
              };
            return Pythagorean[_pytha_reckon]; 
        }

        public int _chalde(char x)
        {
            string _chalde_reckon;
            _chalde_reckon = x.ToString().ToUpper();
            Dictionary<String, int> Chaldean = new Dictionary<String, int>()
            {
            {"A",1}, {"B", 2}, {"C",3}, {"D",4}, {"E", 5}, {"F",8}, {"G",3}, {"H",5}, {"I",1}, {"J",1}, {"K", 2}, {"L",3}, {"M",4}, {"N", 5},
            {"O",7}, {"P",8}, {"Q", 1}, {"R",2}, {"S",3}, {"T", 4}, {"U",6}, {"V",6}, {"W", 6}, {"X",5}, {"Y",1}, {"Z", 7}, {" ",0}
              };
            return Chaldean[_chalde_reckon];

        }

        public int _divine(char x)
        {
            string _divine_reckon;
            _divine_reckon = x.ToString().ToUpper();
            Dictionary<String, int> Divine = new Dictionary<String, int>()
            {
            {"A",1}, {"B", 1}, {"C",1}, {"D",1}, {"E", 1}, {"F",1}, {"G",1}, {"H",1}, {"I",1}, {"J",1}, {"K", 1}, {"L",1}, {"M",1}, {"N", 1},
            {"O",1}, {"P",1}, {"Q", 1}, {"R",1}, {"S",1}, {"T", 1}, {"U",1}, {"V",1}, {"W", 1}, {"X",1}, {"Y",1}, {"Z", 1}, {" ",0}
              };
            return Divine[_divine_reckon];

        }

        public int _jewish(char x)
        {
            string _jewish_reckon;
            _jewish_reckon = x.ToString().ToUpper();
            Dictionary<String, int> Jewish = new Dictionary<String, int>()
            {
            {"A",1}, {"B", 2}, {"C",3}, {"D",4}, {"E", 5}, {"F",6}, {"G",7}, {"H",8}, {"I",9}, {"J",600}, {"K", 10}, {"L",20}, {"M",30}, {"N", 40},
            {"O",50}, {"P",60}, {"Q", 70}, {"R",80}, {"S",90}, {"T", 100}, {"U",200}, {"V",700}, {"W", 900}, {"X",300}, {"Y",400}, {"Z", 500}, {" ",0}
              };
            return Jewish[_jewish_reckon];

        }

        public int _greek(char x)
        {
            string _greek_reckon;
            _greek_reckon = x.ToString().ToUpper();
            Dictionary<String, int> Greek = new Dictionary<String, int>()
            {
            {"A",1}, {"B", 2}, {"C",3}, {"D",4}, {"E", 5}, {"F",90}, {"G",3}, {"H",8}, {"I",10}, {"J",100}, {"K", 20}, {"L",30}, {"M",40}, {"N", 50},
            {"O",70}, {"P",80}, {"Q", 1}, {"R",100}, {"S",200}, {"T", 300}, {"U",400}, {"V",700}, {"W", 800}, {"X",60}, {"Y",400}, {"Z", 7}, {"PH",500}, {"KH",600}, {"PS",700}, {" ",0}
              };
            return Greek[_greek_reckon];

        }

    }
        
}