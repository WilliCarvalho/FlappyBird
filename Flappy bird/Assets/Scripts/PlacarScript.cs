using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlacarScript : MonoBehaviour
{

    public Text txtPontos;
    
    // Start is called before the first frame update
    void Start()
    {
        Config.pontos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        txtPontos.text = Config.pontos.ToString();
    }
}
