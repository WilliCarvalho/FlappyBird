using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScript : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Config.velocidade * Time.deltaTime);

        if (transform.position.x < Config.limiteX)
        {
            transform.position = new Vector2(Config.retornarX, transform.position.y);
        }
    }
}
