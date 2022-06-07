using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyumeMekanigi : MonoBehaviour
{
    private GameObject Cube;
    private Vector3  degistir;
   
    
    // Start is called before the first frame update
    void Start()
    {
        degistir= new Vector3(0f, 10f,0f);
    }

    // Update is called once per frame
    void Update()
    {
        
        Cube.transform.localScale += degistir;

    }
}
