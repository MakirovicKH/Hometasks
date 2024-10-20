namespace WeaponProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Silah məlumatlarını daxil edin:");
            Console.Write("Darağın güllə tutumu: ");
            int magazineCapacity = int.Parse(Console.ReadLine());

            Console.Write("Daraqdakı güllə sayı: ");
            int bulletCount = int.Parse(Console.ReadLine());

            Console.Write("Atış modu (Single/Automatic): ");
            string fireMode = Console.ReadLine();

            // Weapon obyektini yarat
            Weapon weapon = new Weapon(magazineCapacity, bulletCount, fireMode);

            while (true)
            {
                Console.WriteLine("\nSeçim edin:");
                Console.WriteLine("0 - İnformasiya almaq üçün");
                Console.WriteLine("1 - Shoot metodu üçün");
                Console.WriteLine("2 - Fire metodu üçün");
                Console.WriteLine("3 - GetRemainBulletCount metodu üçün");
                Console.WriteLine("4 - Reload metodu üçün");
                Console.WriteLine("5 - ChangeFireMode metodu üçün");
                Console.WriteLine("6 - Proqramdan dayandırmaq üçün");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Console.WriteLine($"Darağın güllə tutumu: {weapon.MagazineCapacity}, Güllə sayı: {weapon.BulletCount}, Atış modu: {weapon.FireMode}");
                        break;
                    case 1:
                        weapon.Shoot();
                        break;
                    case 2:
                        weapon.Fire();
                        break;
                    case 3:
                        Console.WriteLine($"Tam dolması üçün lazım olan güllə sayı: {weapon.GetRemainBulletCount()}");
                        break;
                    case 4:
                        weapon.Reload();
                        break;
                    case 5:
                        weapon.ChangeFireMode();
                        break;
                    case 6:
                        Console.WriteLine("Proqram dayandırıldı.");
                        return;
                    default:
                        Console.WriteLine("Yanlış seçim. Yenidən cəhd edin.");
                        break;
                }
            }
        }
    }
}


