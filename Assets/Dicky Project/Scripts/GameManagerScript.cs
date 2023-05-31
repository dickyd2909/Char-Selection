using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    private GameObject menCam;
    // Start is called before the first frame update
    void Start()
    {
        menCam = Camera.main.gameObject;
        GameObject player =  Instantiate(CharacterSelectionScript.Instance.pilihChar, new Vector3(5, 0.5f, 5), Quaternion.identity);

        // add script playermovement
        player.AddComponent<CharMove>();
        menCam.transform.parent = player.transform;
        menCam.transform.localPosition = new Vector3(0.1f, 1.4f, -1.7f);
        menCam.transform.localEulerAngles = new Vector3(20, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
