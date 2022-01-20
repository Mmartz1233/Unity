using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDeColision : MonoBehaviour
{
   public MoverPelota moverPelota;
   public ControlPuntaje controlPuntaje;
    void ReboteConRqueta(Collision2D c)
    {
        Vector3 posicionPelota = this.transform.position;
        Vector3 posicionRaqueta = c.gameObject.transform.position;
        float altura = c.collider.bounds.size.y;
        float x;
        if (c.gameObject.name == "Raqueta")
        {
            x = 1;
        }else
        {
            x = -1;
        }
        float y = (posicionPelota.y - posicionRaqueta.y) / altura;
        this.moverPelota.AumentarContadorGolpes();
        this.moverPelota.MovimientoPelota(new Vector2(x, y));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Raqueta"||collision.gameObject.name == "Raqueta2")
        {
            this.ReboteConRqueta(collision);
        }else if (collision.gameObject.name == "ParedIzquierda")
        {
            this.controlPuntaje.GolJugador2();
            StartCoroutine(this.moverPelota.IniciarPelota(true));


        }else if (collision.gameObject.name == "ParedDerecha")
        {
            this.controlPuntaje.GolJugador1();
            StartCoroutine(this.moverPelota.IniciarPelota(false));
        }
    }

}
