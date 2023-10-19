using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    public TextoPantalla textObject;
    public TextoVidas textObjectVidas;
    void Start()
    {
        textObject = FindAnyObjectByType<TextoPantalla>();
        textObjectVidas = FindAnyObjectByType<TextoVidas>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left.normalized * speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        textObject.puntos = textObject.puntos + 1 ;
        textObjectVidas.puntosVida = textObjectVidas.puntosVida - 1 ;

        if (collision.gameObject.tag == "Jugador" || collision.gameObject.tag == "Pared")
        {

            if (textObjectVidas.puntosVida == 0)
            {
                Destroy(collision.gameObject);
            }
            Destroy(gameObject);
        }
        else
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

    }
}
