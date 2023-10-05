using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    // Start is called before the first frame update

    public  GameObject instanceObject;

    public Vector3 instancePosition = new Vector3 (0, 0, 0);


    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate (instanceObject, instancePosition, Quaternion.identity);
        }

        


    }
}
