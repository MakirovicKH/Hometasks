using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponProject
{
    internal class Weapon
    {
        // Property olan hissə
        public int MagazineCapacity { get; private set; }
        public int BulletCount { get; private set; }
        public string FireMode { get; private set; } // "Single" və ya "Automatic"

        // Constructor olan hissısi
        public Weapon(int magazineCapacity, int bulletCount, string fireMode)
        {
            MagazineCapacity = magazineCapacity > 0 ? magazineCapacity : 1; // Ən azı 1 olmalıdır
            BulletCount = (bulletCount >= 0 && bulletCount <= magazineCapacity) ? bulletCount : 0; // Güllə sayı doğru olmalıdır
            FireMode = (fireMode == "Single" || fireMode == "Automatic") ? fireMode : "Single"; // Yanlış mod, default "Single" olur
        }

        // Shoot metodu
        public void Shoot()
        {
            if (BulletCount > 0)
            {
                BulletCount--;
                Console.WriteLine("1 güllə atıldı. Qalan güllə sayı: " + BulletCount);
            }
            else
            {
                Console.WriteLine("Daraqda güllə qalmayıb!");
            }
        }

        // Fire metodu
        public void Fire()
        {
            int bulletsFired = BulletCount;
            BulletCount = 0; // Güllələr bitir
            Console.WriteLine($"Bütün güllələr atıldı: {bulletsFired} güllə. Gedən vaxt: {bulletsFired} saniyə.");
        }

        // GetRemainBulletCount metodu
        public int GetRemainBulletCount()
        {
            return MagazineCapacity - BulletCount;
        }

        // Reload metodu
        public void Reload()
        {
            BulletCount = MagazineCapacity;
            Console.WriteLine("Magazine again fulled.");
        }

        // ChangeFireMode metodu
        public void ChangeFireMode()
        {
            FireMode = FireMode == "Single" ? "Automatic" : "Single";
            Console.WriteLine("Shoot mode is changed: " + FireMode);
        }
    }
}
