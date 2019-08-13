using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PipeScript : MonoBehaviour
{
    public float limiteInferior;
    public float limiteSuperior;
    private float posicaoInicialX;
    private float limiteX;
    public Text pt;
    
    // Start is called before the first frame update
    void Start()
    {
        posicaoInicialX = transform.position.x;
        limiteX = -posicaoInicialX;
        transform.position = new Vector2(posicaoInicialX,
                AlterarAltura(limiteInferior, limiteSuperior));
    }

    // Update is called once per frame
    void Update()
    {
        if (Config.jogando)
        {
            transform.Translate(Vector2.left * Config.velocidade * Time.deltaTime);

            if (transform.position.x < limiteX)
            {
                transform.position = new Vector2(posicaoInicialX,
                    AlterarAltura(limiteInferior, limiteSuperior));
            }
        }
    }

    void OnTriggerExit2D(Collider2D c)
    {
        Config.pontos++;
        pt.text = Config.pontos.ToString();
    }


    float AlterarAltura(float i, float s)
    {
        return Random.Range(i, s);
    }
}
