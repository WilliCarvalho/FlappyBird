using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float impulso;
    public bool impulsionar;
    public Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Reatribui o valor da gravidade
            if (Config.jogando == false)
            {
                rb.gravityScale = 1.0f;
            }
            impulsionar = true;
        }
    }

    void FixedUpdate()
    {
        if (impulsionar)
        {
            rb.velocity = new Vector2(0.0f, impulso);
            impulsionar = false;
        }
    }
}
