using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personajecontrol : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidbody2d;
    [SerializeField] Animator animator;
    [SerializeField] float velocidad=5;
    [SerializeField] GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetBool("saltar", true);
            rigidbody2d.AddForce(Vector2.up*velocidad);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetBool("saltar", false);//Comprovar si esta tocando el suelo para saltar

        if (collision.transform.tag == "enemigo")
        {
            gameManager.perder();
        }
    }
}
