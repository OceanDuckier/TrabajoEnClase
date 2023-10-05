using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoesfera : MonoBehaviour
{
    // Start is called before the first frame update

    Vector3 direction = new Vector3(0, 0, 0);
    float speed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction* speed * Time.deltaTime);
        direction.z = 1;
    }
}
