using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerHP : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] List<HeroModel> player = new List<HeroModel>();
    public GameObject hero;
    public int indek;
    public float defaultHp;

    // Start is called before the first frame update
    private void Awake() {
        player = DataLib.DataHero();
    }
    void Start()
    {
        hero = Instantiate(CharacterSelectionScript.Instance.pilihChar, new Vector3(100, 10, 500), Quaternion.identity);;
        indek = GameObject.Find("Selection Character Manager").GetComponent<CharacterSelectionScript>().indexCurr;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (hero)
        {
            int _indexPlayer = indek;
            ivv(_indexPlayer);
            Debug.Log("kena");
        }
    }

    public void ivv(int _indexPlayer)
    {
        player[_indexPlayer].Hp += 10;              
        PlayerPrefs.SetFloat("Hp4", player[_indexPlayer].Hp);
        // if (PlayerPrefs.HasKey("Hp1"))
        // {
        //     player[_indexPlayer].Hp += 10;              
        //     PlayerPrefs.SetFloat("Hp1", player[_indexPlayer].Hp);
        // }
        // else if (PlayerPrefs.HasKey("Hp2"))
        // {
        //     player[_indexPlayer].Hp += 10;              
        //     PlayerPrefs.SetFloat("Hp2", player[_indexPlayer].Hp);
        // }
        // else if (PlayerPrefs.HasKey("Hp3"))
        // {
        //     player[_indexPlayer].Hp += 10;              
        //     PlayerPrefs.SetFloat("Hp3", player[_indexPlayer].Hp);
        // }
        // else if (PlayerPrefs.HasKey("Hp4"))
        // {
        //     player[_indexPlayer].Hp += 10;              
        //     PlayerPrefs.SetFloat("Hp4", player[_indexPlayer].Hp);
        // }
        // else if (PlayerPrefs.HasKey("Hp5"))
        // {
        //     player[_indexPlayer].Hp += 10;              
        //     PlayerPrefs.SetFloat("Hp5", player[_indexPlayer].Hp);
        // }
        StartCoroutine(HoldForNextScene(0));
        Debug.Log(_indexPlayer);
    }

    IEnumerator HoldForNextScene(float _timer)
    {
        yield return new WaitForSeconds(_timer);
        SceneManager.LoadScene("SampleScene");
    }
}
