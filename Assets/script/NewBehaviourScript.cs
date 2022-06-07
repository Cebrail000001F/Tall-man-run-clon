using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    
    

    void OnTriggerEnter(Collider karakter)
    {
        
        if (karakter.gameObject.tag=="EngelBir")
        {
            transform.localScale += new Vector3(0, 2f, 0);            
        }
        if (karakter.gameObject.tag == "EngelIki")
        {
            transform.localScale += new Vector3(2f, 0, 0);
        }
             if (karakter.gameObject.tag == "EngelUc")
        {
            transform.localScale += new Vector3(-2f, 0, 0);
        }
        if (karakter.gameObject.tag == "EngelDort")
        {
            transform.localScale += new Vector3(0, -2f, 0);
        }
    }    
}
