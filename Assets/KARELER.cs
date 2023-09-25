using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KARELER : MonoBehaviour
{

    MeshRenderer ressam;
    public Material lacivert, mor, pembe, sarý, yeþil;
    public AudioSource renk_sesi;

    void Start()
    {
        ressam = GetComponent<MeshRenderer>();
        Renkver();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Renkver();
            renk_sesi.Play();

        }
        
    }

    void Renkver() 
    {

        int rastgele = Random.Range(1, 6);

        switch (rastgele) 
        {

            case 1:
                ressam.material = lacivert;
                break;
            case 2:
                ressam.material = pembe;
                break;
            case 3:
                ressam.material = sarý;
                break;
            case 4:
                ressam.material = yeþil; 
                break;
            case 5: 
                ressam.material = mor;
                break;
        
        }
    
    
    
    }
}
