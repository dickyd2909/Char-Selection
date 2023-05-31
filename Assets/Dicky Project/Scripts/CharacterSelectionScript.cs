using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;

public class CharacterSelectionScript : MonoBehaviour
{
    [SerializeField] List<GameObject> allCharacters = new List<GameObject>();
    [SerializeField] List<GameObject> characterInScene = new List<GameObject>();
    [SerializeField] int counter = 0;
    [SerializeField] GameObject charParent;
    public int indexCurr = 0;

    private int countChar;

    [SerializeField] GameObject characterChoosen;
    // Start is called before the first frame update
    void Start()
    {
        allCharacters = Resources.LoadAll<GameObject>("Characters").ToList();
        //set counter character

        foreach(GameObject item in allCharacters)
        {
            characterInScene.Add(item);
            Instantiate(item, charParent.transform);
        }
        countChar = allCharacters.Count;
        foreach(GameObject item in allCharacters){
            item.SetActive(false);
        }
        
         

        //,menampilkan karakter pertama
        allCharacters[0].SetActive(true);

        FindObjectOfType<HeroDataManager>().UpdateAttributeHero(indexCurr);

    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            NextChar();
        }
        else if(Input.GetKeyDown(KeyCode.Q))
        {
            PrevChar();
        }
        allCharacters[indexCurr].transform.Rotate(Vector3.up * Time.deltaTime * 5);

    }

    void GetAllChildInScene(GameObject _parent){
        foreach(Transform item in _parent.transform)
        {
            characterInScene.Add(item.gameObject);
        }
    }

    public void NextChar()
    {
        counter++;
        indexCurr = HasilBagi(counter, countChar);
        ClearCharacter();
        allCharacters[indexCurr].SetActive(true);

        //isikan nilai ke UI
        FindObjectOfType<HeroDataManager>().UpdateAttributeHero(indexCurr);
    }

    public void PrevChar()
    {
        counter--;
        indexCurr = HasilBagi(counter, countChar);
        ClearCharacter();
        allCharacters[indexCurr].SetActive(true);
        FindObjectOfType<HeroDataManager>().UpdateAttributeHero(indexCurr);
    }

    public void PilihKarakter()
    {
        characterChoosen = allCharacters[indexCurr];
        
        //set annimasi
        characterChoosen.GetComponent<Animator>().SetTrigger("attack");

        HoldForNextScene(2);

        StartCoroutine(HoldForNextScene(2.5f));
    }

    IEnumerator HoldForNextScene(float _timer)
    {
        yield return new WaitForSeconds(_timer);
        SceneManager.LoadScene("ingame"); 
    }

    private int HasilBagi(int _counter, int _kapasitas)
    {
        return _counter % _kapasitas;
    }

    private void ClearCharacter(){
        foreach(GameObject item in allCharacters)
        {
            item.SetActive(false);
        }
    }
}
