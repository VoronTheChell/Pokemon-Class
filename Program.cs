using System;

namespace ParktickWork___Pokemon_Class
{
    // Создаем общий класс Pokemon для хранения няшек
    public class Pokemon
    {
        public string Name { get; set; } // Имя няшки
        public string Type1 { get; set; } // Тип для няшки
        public string Type2 { get; set; } // может быть null, если тип один для няшки

        public int HP { get; set; } // Здоровье няшки
        public int Attack { get; set; } // Аттака няшки
        public int Defense { get; set; } // Защита няшки

        public int special_attack { get; set; } // Спец. Аттака Няшки
        public int special_defense { get; set; } // Спец. Защита Няшки
        public int Speed { get; set; } // Скорость няшки

        // Здесь мы делаем публичныйм переменную Pokemon для записи няшек
        public Pokemon(string name, string type1, int hp, int attack, int defense, int specialAttack, int specialDefense, int speed, string type2 = null) 
        {
            Name = name;
            Type1 = type1;
            Type2 = type2;
            HP = hp;
            Attack = attack;
            Defense = defense;
            special_attack = specialAttack;
            special_defense = specialDefense;
            Speed = speed;
        }

        // Вывод статистики няшек
        public void statics()
        {
            if (Type2 != null) // Если тип 2 заполнен выводить его
            {
                Console.WriteLine($"Name: Litwick \nType: {Type1} & {Type2} \nHP:{HP} PT \nAttack:{Attack} PT \nDefense:{Defense} PT \nSpecial Attack: {special_attack} PT \nSpecial Defense: {special_defense} PT \nSpeed:{Speed} PT");
            }

            else // В инном случаи не выводить
            {
                Console.WriteLine($"Name: Litwick \nType: {Type1} \nHP:{HP} PT \nAttack:{Attack} PT \nDefense:{Defense} PT \nSpecial Attack: {special_attack} PT \nSpecial Defense: {special_defense} PT \nSpeed:{Speed} PT");
            }
        }
    }

    // Записываем Няшки
    public class Litwick : Pokemon
    {
        public Litwick() : base("Litwick", "Ghost", 50, 30, 55, 65, 55, 20, "Fire") { }
    }

    public class Lampent : Pokemon
    {
        public Lampent() : base("Lampent", "Ghost", 60, 40, 60, 95, 60, 55, "Fire") { }
    }

    class Chandelure : Pokemon
    {
        public Chandelure() : base("Chandelure", "Ghost", 60, 55, 90, 145, 90, 80, "Fire") { }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            bool workApp = true;

            while (workApp)
            {
                Console.WriteLine("Select Pokemon:\n1) Litwick\n2) Lampent\n3) Chandelure");
                Console.Write("Write number Pokemon: ");
                int select = int.Parse(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        {
                            Console.Clear();
                            Litwick litwick = new Litwick();
                            litwick.statics();
                            Console.WriteLine("Press any key...");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            Lampent lampent = new Lampent();
                            lampent.statics();
                            Console.WriteLine("Press any key...");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }

                    case 3:
                        {
                            Console.Clear();
                            Chandelure chandelure = new Chandelure();
                            chandelure.statics();
                            Console.WriteLine("Press any key...");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }

                    case 0:
                        {
                            Console.Clear();
                            workApp = false;
                            break;
                        }
                }
            }
        }
    }
}

// Брал инфу о покемонах (ну или няшек как здесь :) ) с этой сайта: https://pokemondb.net
