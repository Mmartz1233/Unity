using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ControlPuntaje : MonoBehaviour
{
    private int puntajeJugador1 = 0;
    private int puntajeJugador2 = 0;
    public GameObject textoPuntaje1;
    public GameObject textoPuntaje2;
    public int metaParaGanar;

    void Update()
    {
        //if (this.puntajeJugador1 >= this.metaParaGanar || this.puntajeJugador2 >= this.metaParaGanar)
        //{
        //    SceneManager.LoadScene("JuegoTerminado");
        //    print("Juego ganado");
        //}

        if (this.puntajeJugador1 >= this.metaParaGanar)
        {
            print("Juego ganado por jugador 1");
            SceneManager.LoadScene("JuegoTerminado");
        } else if (this.puntajeJugador2 >= this.metaParaGanar)
        {
            print("Juego ganado por jugador 2");
            SceneManager.LoadScene("JuegoTerminadojugador2");
        }
    }
    private void FixedUpdate()
    {
        Text etiquetaPuntaje1 = this.textoPuntaje1.GetComponent<Text>();
        etiquetaPuntaje1.text = this.puntajeJugador1.ToString();

        Text etiquetaPuntaje2 = this.textoPuntaje2.GetComponent<Text>();
        etiquetaPuntaje2.text = this.puntajeJugador2.ToString();
    }

    public void GolJugador1()
    {
        this.puntajeJugador1++;
    }

    public void GolJugador2()
    {
        this.puntajeJugador2++;
    }
}
