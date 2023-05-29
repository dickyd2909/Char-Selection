using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectionScript : MonoBehaviour
{
    [SerializeField] List<GameObject> allCharacters = new List<GameObject>();
    [SerializeField] int counter = 0;
    [SerializeField] int indexCurr;

    private int countChar;
    // Start is called before the first frame update
    void Start()
    {
        //set counter character
        countChar = allCharacters.Count;
        foreach(GameObject item in allCharacters){
            item.SetActive(false);
        } 

        allCharacters[0].SetActive(true);

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
    }

    public void NextChar()
    {
        counter++;
        indexCurr = HasilBagi(counter, countChar);
        ClearCharacter();
        allCharacters[indexCurr].SetActive(true);
    }

    public void PrevChar()
    {
        counter--;
        indexCurr = HasilBagi(counter, countChar);
        ClearCharacter();
        allCharacters[indexCurr].SetActive(true);
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
