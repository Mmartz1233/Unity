using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSonido : MonoBehaviour
{
    public AudioSource miMusica;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))//si se presiona la tecla espaciadora pregunta si hay musica 
        {
            if (miMusica)
            {
                if (miMusica.isPlaying)//si la musica se esta reproduciendo 
                {
                    miMusica.Pause();//coloca la musica en pausa
                }else
                {
                    miMusica.Play();//coloca la musica en play
                }
            }
        }
    }
}
