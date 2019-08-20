using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public float impulso;
    public AudioClip[] clips;
    public bool impulsionar;
    public Rigidbody2D rb;
    private AudioSource audios;

    
    // Start is called before the first frame update
    void Start()
    {
        audios = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Reatribui o valor da gravidade
            if (Config.jogando == false && !Config.jogando)
            {
                rb.gravityScale = 1.0f;
                Config.jogando = true;
            }
            impulsionar = true;
        }
    }

    void FixedUpdate()
    {
        if (impulsionar)
        {
            PlayAudio(0);
            rb.velocity = new Vector2(0.0f, impulso);
            impulsionar = false;
        }
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        PlayAudio(1);
        StartCoroutine(ExitGame());
    }

    IEnumerator ExitGame()
    {
        Config.jogando = false;
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("MenuScene");
    }

    void OnTriggerExit2D(Collider2D c)
    {
        Config.pontos++;
        c.GetComponent<AudioSource>().Play();
    }

    void PlayAudio(int i)
    {
        //Carrega o clip de audio mp3
        audios.clip = clips[0];
        //reproduz o audio carregado
        audios.Play();
    }
}
