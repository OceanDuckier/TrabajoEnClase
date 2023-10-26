using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botónreintentar : MonoBehaviour
{
    public void botónJugar()
    {
        SceneManager.LoadScene(1);
    }
    public void botónComenzar()
    {
        SceneManager.LoadScene(1);
    }

    public void SalirdelJuego()
    {
        Application.Quit();
    }
}
