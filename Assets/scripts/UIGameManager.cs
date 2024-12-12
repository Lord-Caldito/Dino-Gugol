using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIGameManager : MonoBehaviour
{
    [SerializeField] TMP_Text puntuacionActual, puntuacionMaxima;
    [SerializeField] GameManager gameManager;
    [SerializeField] GameManagerPersona2 gameManagerPersona2;

    [SerializeField] TMP_Text tiempo;

    // Update is called once per frame
    void Update()
    {
        puntuacionActual.text = $"{gameManagerPersona2.puntuacionActual:D3}";
        puntuacionMaxima.text = $"{gameManagerPersona2.puntuacionMaxima:D3}";
        int minutos = (int)gameManagerPersona2.tiempo / 60;
        int segundos = (int)gameManagerPersona2.tiempo % 60;
        Debug.Log($"{minutos:D2}:{segundos:D2}");
        tiempo.text = $"{minutos:D2}:{segundos:D2}";
    }
}
