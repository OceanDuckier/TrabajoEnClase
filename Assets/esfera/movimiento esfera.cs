using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoesfera : MonoBehaviour
{
    // Start is called before the first frame update


    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right* speed * Time.deltaTime);
    }
}
