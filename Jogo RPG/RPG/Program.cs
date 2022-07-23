using System;
using RPG.src.Entities;

namespace RPG
{
    class Program
    {
        static void Main (string[] args)
        {
            string optionPlayer = CaptureOptionPlayer();

            Knight Arus = new Knight("Arus", 23, "Knight", 540, 120);
            Sorcerer Alan = new Sorcerer("Alan", 30, "Sorcerer", 300, 270);
            Druid Amy = new Druid("Amy", 45, "Druid", 450, 350);
            Paladin Acher = new Paladin("Acher", 37, "Paladin", 435, 250);

            while (optionPlayer.ToUpper() != "X")
            {
                switch (optionPlayer)
                {
                    case "1":
                        Console.WriteLine("Nome | Level | Classe | HP | MP");
                        Console.WriteLine(Arus.Name + " " + Arus.Level + " " + Arus.HeroType + " " + Arus.HP + " " + Arus.MP);
                        Console.WriteLine(Alan.Name + " " + Alan.Level + " " + Alan.HeroType + " " + Alan.HP + " " + Alan.MP);
                        Console.WriteLine(Amy.Name + " " + Amy.Level + " " + Amy.HeroType + " " + Amy.HP + " " + Amy.MP);
                        Console.WriteLine(Acher.Name + " " + Acher.Level + " " + Acher.HeroType + " " + Acher.HP + " " + Acher.MP);
                        break;

                    case "2":
                        Console.WriteLine(Alan.Attack(100));
                        Console.WriteLine(Arus.Attack());
                        Console.WriteLine(Alan.Heal());
                        Console.WriteLine(Amy.Heal(60));
                        Console.WriteLine(Acher.Attack(120));                    
                        break;

                    case "3":
                        Console.WriteLine("Nome | HP | MP");
                        Console.WriteLine(Arus.Name + " " + Arus.HP + " " + Arus.MP);
                        Console.WriteLine(Alan.Name + " " + Alan.HP + " " + Alan.MP);
                        Console.WriteLine(Amy.Name + " " + Amy.HP + " " + Amy.MP);
                        Console.WriteLine(Acher.Name + " " + Acher.HP + " " + Acher.MP);
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();

                }
                optionPlayer = CaptureOptionPlayer();    
            }
        }

        private static string CaptureOptionPlayer()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Listar sua equipe");
            Console.WriteLine("2 - Apresentar campo de batalha");
            Console.WriteLine("3 - Apresentar status HP e MP");
            Console.WriteLine("X - Sair");

            Console.WriteLine();

            string optionPlayer = Console.ReadLine();
            Console.WriteLine();
            return optionPlayer;
        }

    }

}
