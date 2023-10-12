using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientobueno : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject instanceObject;

    public float speed;

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
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down.normalized * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up.normalized * speed * Time.deltaTime);
        }

    }
}
