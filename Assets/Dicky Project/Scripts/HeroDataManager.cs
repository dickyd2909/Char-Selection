using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HeroDataManager : MonoBehaviour
{
     [SerializeField] List<HeroModel> hero = new List<HeroModel>();

    /* UI */
    [SerializeField] TextMeshProUGUI titleHero;
    [SerializeField] TextMeshProUGUI descHero;

    [SerializeField] Image _sHP;
    [SerializeField] Image _sMana;
    [SerializeField] Image _sDamage;
    [SerializeField] Image _sArmor;
    [SerializeField] Image _sStrength;
    [SerializeField] Image _sAgility;
    [SerializeField] Image _sIntelligent;

    [SerializeField] TextMeshProUGUI _nHP;
    [SerializeField] TextMeshProUGUI _nMana;
    [SerializeField] TextMeshProUGUI _nDamage;
    [SerializeField] TextMeshProUGUI _nArmor;
    [SerializeField] TextMeshProUGUI _nStrength;
    [SerializeField] TextMeshProUGUI _nAgility;
    [SerializeField] TextMeshProUGUI _nIntelligent;

    float lebarUI;

    private void Awake()
    {
        lebarUI = _sHP.GetComponent<RectTransform>().sizeDelta.x;
        hero = DataLib.DataHero();
    }

    // Start is called before the first frame update
    void Start()
    {
        //_sHP.GetComponent<RectTransform>().sizeDelta = new Vector2(hero[0].Hp, _sHP.GetComponent<RectTransform>().sizeDelta.y);
    }

    public void UpdateAttributeHero(int _indexHero)
    {
        //UI
        _sHP.GetComponent<RectTransform>().sizeDelta = new Vector2(proporsi(hero[_indexHero].Hp, lebarUI), _sHP.GetComponent<RectTransform>().sizeDelta.y);
        _sMana.GetComponent<RectTransform>().sizeDelta = new Vector2(proporsi(hero[_indexHero].Mana, lebarUI), _sMana.GetComponent<RectTransform>().sizeDelta.y);
        _sDamage.GetComponent<RectTransform>().sizeDelta = new Vector2(proporsi(hero[_indexHero].Damage, lebarUI), _sDamage.GetComponent<RectTransform>().sizeDelta.y);
        _sArmor.GetComponent<RectTransform>().sizeDelta = new Vector2(proporsi(hero[_indexHero].Armor, lebarUI), _sArmor.GetComponent<RectTransform>().sizeDelta.y);
        _sStrength.GetComponent<RectTransform>().sizeDelta = new Vector2(proporsi(hero[_indexHero].Strength, lebarUI), _sStrength.GetComponent<RectTransform>().sizeDelta.y);
        _sAgility.GetComponent<RectTransform>().sizeDelta = new Vector2(proporsi(hero[_indexHero].Agility, lebarUI), _sAgility.GetComponent<RectTransform>().sizeDelta.y);
        _sIntelligent.GetComponent<RectTransform>().sizeDelta = new Vector2(proporsi(hero[_indexHero].Intelligent, lebarUI), _sIntelligent.GetComponent<RectTransform>().sizeDelta.y);

        //UI - Title
        titleHero.GetComponent<TextMeshProUGUI>().text = hero[_indexHero].Nama;
        descHero.GetComponent<TextMeshProUGUI>().text = hero[_indexHero].Deskripsi;

        //UI - Value
        _nHP.GetComponent<TextMeshProUGUI>().text = hero[_indexHero].Hp.ToString();
        _nMana.GetComponent<TextMeshProUGUI>().text = hero[_indexHero].Mana.ToString();
        _nDamage.GetComponent<TextMeshProUGUI>().text = hero[_indexHero].Damage.ToString();
        _nArmor.GetComponent<TextMeshProUGUI>().text = hero[_indexHero].Armor.ToString();
        _nStrength.GetComponent<TextMeshProUGUI>().text = hero[_indexHero].Strength.ToString();
        _nAgility.GetComponent<TextMeshProUGUI>().text = hero[_indexHero].Agility.ToString();
        _nIntelligent.GetComponent<TextMeshProUGUI>().text = hero[_indexHero].Intelligent.ToString();
    }

    float proporsi(float _nilai, float _lebarUI)
    {
        return _nilai / 500 * _lebarUI;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
