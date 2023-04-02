namespace PlayersAndMonsters
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string type = Console.ReadLine();

            string username = Console.ReadLine();
            int level = int.Parse(Console.ReadLine());

            if(type == "Elf")
            {
                Hero elf = new Elf(username, level);
                Console.WriteLine(elf);
            }
            else if (type == "MuseElf")
            {
                Hero museElf = new MuseElf(username, level);
                Console.WriteLine(museElf);
            }
            else if (type == "Wizard")
            {
                Hero wizard = new Wizard(username, level);
                Console.WriteLine(wizard);
            }
            else if (type == "DarkWizard")
            {
                Hero darkWizard = new DarkWizard(username, level);
                Console.WriteLine(darkWizard);
            }
            else if (type == "SoulMaster")
            {
                Hero soulMaster = new SoulMaster(username, level);
                Console.WriteLine(soulMaster);
            }
            else if (type == "Knight")
            {
                Hero knight = new Knight(username, level);
                Console.WriteLine(knight);
            }
            else if (type == "DarkKnight")
            {
                Hero darkKnight = new DarkKnight(username, level);
                Console.WriteLine(darkKnight);
            }
            else if (type == "BladeKnight")
            {
                Hero bladeKnight = new BladeKnight(username, level);
                Console.WriteLine(bladeKnight);
            }

            

        }
    }
}