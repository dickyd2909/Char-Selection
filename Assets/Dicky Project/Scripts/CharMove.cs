using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMove : MonoBehaviour
{
    Transform myTransform;
    Animator myAnim;
    private void Awake() {

    }

    // Start is called before the first frame update
    void Start()
    {
        myTransform = transform;
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       attack(); 
    }

    void Movement()
    {
        //ambil nilai
        // float x = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        // float z = Input.GetAxisRaw("Vertical") * Time.deltaTime;

        // myTransform.position += new Vector3(x, myTransform.position.y, z);

        // if(x != 0 || z != 0)
        // {
        //     myAnim.SetBool("run", true);
        // }else
        // {
        //     myAnim.SetBool("run", false);
        // }
        
    }  

    void attack()
    {
        if(myAnim.GetCurrentAnimatorStateInfo(0).IsName("run")) return;
 
        if(Input.GetKeyDown(KeyCode.Space))
        {
            myAnim.SetTrigger("attack");
        }
    }
}
