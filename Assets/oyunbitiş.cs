using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunbitiş : MonoBehaviour
{

    public MeshRenderer kare1, kare2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (kare1.material.name == kare2.material.name) 
        
        {
            Debug.Log("Tebrikler Kazandınız");
        
        
        }
        
    }
}
