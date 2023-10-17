using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject instanceObject;
    bool spawnAleatorio = true;





    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(instanceObject, transform.position, Quaternion.identity);
        }
        if (spawnAleatorio == true) 
        {
            Instantiate(instanceObject, transform.position, Quaternion.identity);
        }
        
    }
    
}
