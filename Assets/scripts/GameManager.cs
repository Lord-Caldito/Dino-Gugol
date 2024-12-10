using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public int puntuacionActual, puntuacionMaxima;
    [SerializeField] public float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        puntuacionMaxima = PlayerPrefs.GetInt("mejorPuntuacion");
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void perder()
    {
        Debug.Log("perder");
    }
    public void reiniciarJuego()
    {

    }
    public void actualizarPuntuacion()
    {
        Debug.Log("punto");

        puntuacionActual++;
        if (puntuacionActual > puntuacionMaxima)
        {
            puntuacionMaxima = puntuacionActual;
            PlayerPrefs.GetInt("mejorPuntuacion");
        }
    }
}
