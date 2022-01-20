using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPelota : MonoBehaviour
{
    public float VelocidadMovimiento;
    public float VelocidadExtraPorGolpe;
    public float VelocidadExtraMaxima;
    int contadorGolpes = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(this.IniciarPelota());
    }
    public IEnumerator IniciarPelota (bool comienzaJugador1 = true)
    {
        this.PosicionarPelota(comienzaJugador1);
        this.contadorGolpes = 0;
        yield return new WaitForSeconds(2);
        if (comienzaJugador1)
        {
            this.MovimientoPelota(new Vector2(-1, 0));
        }
        else
        {
            this.MovimientoPelota(new Vector2(1, 0));
        }
    }
    //Funcion para resetear el juego y que empiece del lado del jugador
    void PosicionarPelota (bool comienzaJugador1)
    {
        
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);//reduciomos la velocidad de la pelota
        //determinamos donde la posicionamos
        if (comienzaJugador1)//si comienza jugador1
        {
            this.gameObject.transform.localPosition = new Vector3(-100, 0, 0);// pocionada del lado izq en x
        }else
        {
            this.gameObject.transform.localPosition = new Vector3(100, 0, 0);// pocionada del lado der en x
        }

    }



    public void MovimientoPelota(Vector2 dir)
    {
        dir = dir.normalized;
        float velocidad = this.VelocidadMovimiento + this.contadorGolpes * VelocidadExtraPorGolpe;
        Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = dir * velocidad;
    }
    public void AumentarContadorGolpes()
    {
        if (this.contadorGolpes * this.VelocidadExtraPorGolpe <= this.VelocidadExtraMaxima)
        {
            this.contadorGolpes++;
        }
    }
}
