using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class HeroModel
{
    private string kode;
    private string nama;
    private string deskripsi;
    private float hp;
    private float mana;
    private float agility;
    private float strength;
    private float intelligent;
    private float armor;
    private float damage;
    private List<AbilityModel> ability = new List<AbilityModel>();

    public string Kode { get => kode; set => kode = value; }
    public string Nama { get => nama; set => nama = value; }
    public string Deskripsi { get => deskripsi; set => deskripsi = value; }
    public float Hp { get => hp; set => hp = value; }
    public float Mana { get => mana; set => mana = value; }
    public float Agility { get => agility; set => agility = value; }
    public float Strength { get => strength; set => strength = value; }
    public float Intelligent { get => intelligent; set => intelligent = value; }
    public float Armor { get => armor; set => armor = value; }
    public float Damage { get => damage; set => damage = value; }
    public List<AbilityModel> Ability { get => ability; set => ability = value; }
}
