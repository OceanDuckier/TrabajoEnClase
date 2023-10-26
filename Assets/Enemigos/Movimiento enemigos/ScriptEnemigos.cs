using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptEnemigos : MonoBehaviour
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


        if (collision.gameObject.tag == "Pared")
        {
            
        }
        else if (collision.gameObject.tag == "Jugador")
        {
            textObjectVidas.puntosVida = textObjectVidas.puntosVida - 1;
            if (textObjectVidas.puntosVida == 0)
           {
                Destroy(collision.gameObject);
                SceneManager.LoadScene(0);
            }
            Destroy(gameObject);

        }
        else
        {
            textObject.puntos = textObject.puntos + 1;
            Destroy(collision.gameObject);
            Destroy(gameObject);
            if (textObject.puntos == 10)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
