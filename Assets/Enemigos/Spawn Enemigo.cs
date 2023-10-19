using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject enemigo;
    public float max;
    public float minimo;
    public float timer;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;

        if ( timer <= 0)
        {
            float posY = Random.Range(minimo, max);
            Instantiate(enemigo, new Vector3(transform.position.x, posY, 0), Quaternion.identity);
            timer = 2;
        }


        
    }
    
}
