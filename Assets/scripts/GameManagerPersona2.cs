using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManagerPersona2 : MonoBehaviour
{
    [SerializeField] public int puntuacionActual, puntuacionMaxima;
    [SerializeField] public float tiempo;
    [SerializeField] GameObject jugador, enemigo, botonReiniciar, textoGameOver; 
    [SerializeField] bool cronómetro = false;
    [SerializeField] Enemigo1 enemigo1;
    // Start is called before the first frame update
    void Start()
    {
        puntuacionMaxima = PlayerPrefs.GetInt("mejorPuntuacion");
        textoGameOver.SetActive(false);
        botonReiniciar.SetActive(false);
        cronómetro = true;
    }

    // Update is called once per frame
    void Update()
    {
     if (cronómetro)
        {
            tiempo += Time.deltaTime;
        }
    }



    public void perder()
    {
        jugador.SetActive(false);
        enemigo.SetActive(false);
        textoGameOver.SetActive(true);
        botonReiniciar.SetActive(true);
        cronómetro = false;
        Debug.Log("perder");
    }
    public void reiniciarJuego()
    {
        puntuacionActual = 0;
        jugador.SetActive(true);
        enemigo.SetActive(true);
        textoGameOver.SetActive(false);
        botonReiniciar.SetActive(false);
        tiempo = 0f;
        cronómetro = true;
        enemigo1.IniciarEnemigo();
        
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
