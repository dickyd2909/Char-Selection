using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
   
    public float kecepatan = 7f;

    public GameObject player;
    private GameObject menCam;
    private CharacterController carkon;
    private float x, z;
    // Start is called before the first frame update
    void Start()
    {
        menCam = Camera.main.gameObject;
        player =  Instantiate(CharacterSelectionScript.Instance.pilihChar, new Vector3(5, 0.5f, 5), Quaternion.identity);
        menCam.transform.parent = player.transform;
        menCam.transform.localPosition = new Vector3(0.27f, 2.11f, -2.9f);
        menCam.transform.localEulerAngles = new Vector3(11, 0, 0);
        carkon = player.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        bergerak();
    }

    private void bergerak()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        Vector3 gerakan = transform.right * x + transform.forward * z;
        carkon.Move(gerakan * kecepatan * Time.deltaTime);
    }
}
