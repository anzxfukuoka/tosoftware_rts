using System;

namespace ConsoleApp1
{
    class Robot
    {
        public static int count = 0;

        private string name;
        private int level;
        private float hp;

        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                if (value < hp)
                    level = 0;
                else if (value > hp)
                    level++;
                else
                    level = value;

            }
        }

        public Robot ()
            {
            name = "Robot";
            level = 1 ;
            hp= 1 ;

            
            Print();
            }
        public Robot(string name, int level, float hp)
        {
            this.name = name;
            this.level = level;
            this.hp = hp;


            Print();
            }

        public void Print ()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Level:" + level);
            Console.WriteLine("Hp" + hp);

        }


    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Robot gun = new Robot();
            gun.Level = 0;
            Console.WriteLine(gun.Level);
            Robot lasereyes = new Robot();
            lasereyes.Level = 0;

            Console.ReadKey();

        }
    }

}
