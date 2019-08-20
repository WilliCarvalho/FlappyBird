using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Config : MonoBehaviour
{
    public static int pontos;
    public static float velocidade = 5;
    public static float limiteX = -9.91f;
    public static float retornarX = 3.225f;
    public static bool jogando;
    public Text textPoints;


    public void Start()
    {
        textPoints.text = pontos.ToString();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Gameplay");
    }

}
