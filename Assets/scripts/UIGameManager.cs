using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIGameManager : MonoBehaviour
{
    [SerializeField] TMP_Text puntuacionActual, puntuacionMaxima;
    [SerializeField] GameManager gameManager;

    // Update is called once per frame
    void Update()
    {
        puntuacionActual.text = $"{gameManager.puntuacionActual:D3}";
        puntuacionMaxima.text = $"{gameManager.puntuacionMaxima:D3}";
    }
}
