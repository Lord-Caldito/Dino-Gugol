using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo1 : MonoBehaviour
{
    [SerializeField] Camera camara;
    [SerializeField] Vector2 posicionInicial;
    [SerializeField] Vector2 posicionMinima;
    [SerializeField] float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        camara = Camera.main;
        posicionMinima = camara.ViewportToWorldPoint(new Vector2(0, 0));
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocidad * Time.deltaTime * Vector2.left);
        if (transform.position.x< posicionMinima.x)
        {
            transform.position = posicionInicial;

            if (velocidad <= 10)
            {
                velocidad = velocidad + 1;
            }
        }
    }
}
