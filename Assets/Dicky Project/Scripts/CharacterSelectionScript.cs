using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;

public class CharacterSelectionScript : MonoBehaviour
{
    private static CharacterSelectionScript instance;
    public static CharacterSelectionScript Instance
    {
        get { return instance; }
        private set { instance = value; }
    }
    [SerializeField] List<GameObject> allChar = new List<GameObject>();
    [SerializeField] List<GameObject> CharScene = new List<GameObject>();
    [SerializeField] int counter = 0;
    public int indexCurr = 0;

    private int countChar;
    public GameObject ChooseChar;
    [SerializeField] GameObject charParent;
    
    private void Awake() {
        if (instance != null && instance == this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        allChar = Resources.LoadAll<GameObject>("Characters").ToList();
        foreach (GameObject item in allChar)
        {
            Instantiate(item, charParent.transform);
        }
        GetAllChar(charParent);

        countChar = allChar.Count;

        ClearChar();
        
        CharScene[0].SetActive(true);
        FindObjectOfType<HeroDataManager>().UpdateAttributeHero(indexCurr);
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.E))
        // {
        //     NextChar();
        // }
        // else if(Input.GetKeyDown(KeyCode.Q))
        // {
        //     PrevChar();
        // }
        foreach (GameObject item in CharScene)
        {
            if (item == null) return;
        }
        allChar[indexCurr].transform.Rotate(Vector3.up * Time.deltaTime);
    }

    void GetAllChar(GameObject _parent)
    {
        foreach (Transform item in _parent.transform)
        {
            CharScene.Add(item.gameObject);
        }
    }

    public void NextChar()
    {
        counter++;
        indexCurr = HasilBagi(counter, countChar);

        ClearChar();
        CharScene[indexCurr].SetActive(true);
        FindObjectOfType<HeroDataManager>().UpdateAttributeHero(indexCurr);
    }

    public void PrevChar()
    {
        counter--;
        indexCurr = HasilBagi(counter, countChar);

        ClearChar();
        CharScene[indexCurr].SetActive(true);
        FindObjectOfType<HeroDataManager>().UpdateAttributeHero(indexCurr);
    }

    private int HasilBagi(int _counter, int _kapasitas)
    {
        return _counter % _kapasitas;
    }

    private void ClearChar()
    {
        foreach (GameObject item in CharScene)
        {
            item.SetActive(false);
        }
    }

    public void PilihKarakter()
    {
        ChooseChar = allChar[indexCurr];
        CharScene[indexCurr].GetComponent<Animator>().SetTrigger("attack");
        StartCoroutine(HoldForNextScene(2));
    }

    IEnumerator HoldForNextScene(float _timer)
    {
        yield return new WaitForSeconds(_timer);
        SceneManager.LoadScene("ingame");
    }
}
