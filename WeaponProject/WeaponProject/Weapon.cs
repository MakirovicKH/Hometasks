using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Weapon
{
    // Property-lər
    public int MagazineCapacity { get; }
    public int BulletCount { get; }
    public string FireMode { get; }

    // Constructor
    public Weapon(int magazineCapacity, int bulletCount, string fireMode)
    {
    }

    // Shoot metodu
    public void Shoot()
    {
        if (BulletCount > 0)
        {
            
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
        
        Console.WriteLine($"Bütün güllələr atıldı: {BulletCount} güllə. Gedən vaxt: {BulletCount} saniyə.");
    }

    // GetRemainBulletCount metodu
    public int GetRemainBulletCount()
    {
        return MagazineCapacity - BulletCount; // Qalan güllə sayını döndərir
    }

    // Reload metodu - readonly olduğu üçün bu metodda heç bir dəyişiklik etməyimiz mümkün deyil
    public void Reload()
    {
        Console.WriteLine("Reload operation cannot be performed since BulletCount is readonly.");
    }

    // ChangeFireMode metodu - readonly olduğu üçün bu metodda heç bir dəyişiklik etməyimiz mümkün deyil
    public void ChangeFireMode()
    {
        Console.WriteLine("ChangeFireMode operation cannot be performed since FireMode is readonly.");
    }
}
