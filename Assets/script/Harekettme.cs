using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harekettme : MonoBehaviour
{
    
    void Update()
    {  
        if (Input.GetKey("w"))
        {
           ObjeIleriGider();
         }
        
        if (Input.GetKey("d"))
        {
            ObjeSagaGider();
        }
        
        if (Input.GetKey("a"))
        {
            ObjeSolaGider();
        }

    }
    //obje ileri gider
    public void ObjeIleriGider()
    {
        transform.Translate(transform.forward*-1*Time.deltaTime*12f);
    }
    //obje ileri gider
    public void ObjeSagaGider()
    {
        transform.Translate(transform.right * -1 * Time.deltaTime*10f);
    }
    //obje ileri gider
    public void ObjeSolaGider()
    {
        transform.Translate(transform.right * Time.deltaTime*10f);
    }
    
   
    
}
