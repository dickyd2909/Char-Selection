using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataLib
{
    public static List<HeroModel> DataHero()
    {
        List<HeroModel> heroModels = new List<HeroModel>();

        /* Hero 1 */
        HeroModel h1 = new HeroModel()
        {
            Kode = "001",
            Nama = "Dom",
            Hp = 80,
            Mana = 400,
            Agility = 90,
            Armor = 40,
            Damage = 120,
            Deskripsi = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tincidunt, sem a fringilla scelerisque, ligula orci feugiat odio, sit amet gravida lectus lorem nec odio. Nulla facilisi. Nulla id lorem eu magna egestas laoreet. Morbi iaculis est at mattis ultricies. ",
            Intelligent = 78,
            Strength = 100,
            Ability = new List<AbilityModel>() { new AbilityModel() { Kode = "a1", Nama = "Terkaman", ImagePath = "Dom_Terkam" } }
        };

        /* Hero 2 */
        HeroModel h2 = new HeroModel()
        {
            Kode = "002",
            Nama = "Tej",
            Hp = 90,
            Mana = 300,
            Agility = 83,
            Armor = 61,
            Damage = 160,
            Deskripsi = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tincidunt, sem a fringilla scelerisque, ligula orci feugiat odio, sit amet gravida lectus lorem nec odio. Nulla facilisi. Nulla id lorem eu magna egestas laoreet. Morbi iaculis est at mattis ultricies.",
            Intelligent = 60,
            Strength = 100,
            Ability = new List<AbilityModel>() { new AbilityModel() { Kode = "a2", Nama = "Menendang", ImagePath = "Tej_Menendang" } }
        };

        /* Hero 3 */
        HeroModel h3 = new HeroModel()
        {
            Kode = "003",
            Nama = "Roman",
            Hp = 86,
            Mana = 500,
            Agility = 70,
            Armor = 30,
            Damage = 100,
            Deskripsi = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tincidunt, sem a fringilla scelerisque, ligula orci feugiat odio, sit amet gravida lectus lorem nec odio. Nulla facilisi. Nulla id lorem eu magna egestas laoreet. Morbi iaculis est at mattis ultricies.",
            Intelligent = 82,
            Strength = 100,
            Ability = new List<AbilityModel>() { new AbilityModel() { Kode = "a3", Nama = "Blink", ImagePath = "Roman_Blink" } }
        };

        /* Hero 4 */
        HeroModel h4 = new HeroModel()
        {
            Kode = "004",
            Nama = "Erica",
            Hp = 88,
            Mana = 350,
            Agility = 78,
            Armor = 66,
            Damage = 190,
            Deskripsi = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tincidunt, sem a fringilla scelerisque, ligula orci feugiat odio, sit amet gravida lectus lorem nec odio. Nulla facilisi. Nulla id lorem eu magna egestas laoreet. Morbi iaculis est at mattis ultricies.",
            Intelligent = 80,
            Strength = 100,
            Ability = new List<AbilityModel>() { new AbilityModel() { Kode = "a4", Nama = "Speeding", ImagePath = "Erica_Speeding" } }
        };

        /* Hero 5 */
        HeroModel h5 = new HeroModel()
        {
            Kode = "005",
            Nama = "Carlina",
            Hp = 80,
            Mana = 320,
            Agility = 80,
            Armor = 70,
            Damage = 120,
            Deskripsi = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tincidunt, sem a fringilla scelerisque, ligula orci feugiat odio, sit amet gravida lectus lorem nec odio. Nulla facilisi. Nulla id lorem eu magna egestas laoreet. Morbi iaculis est at mattis ultricies.",
            Intelligent = 78,
            Strength = 100,
            Ability = new List<AbilityModel>() { new AbilityModel() { Kode = "a4", Nama = "Killing", ImagePath = "Carlina_Killing" } }
        };

        heroModels.Add(h1);
        heroModels.Add(h2);
        heroModels.Add(h3);
        heroModels.Add(h4);
        heroModels.Add(h5);

        return heroModels;
    }
}
