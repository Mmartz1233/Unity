using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//administar elementos de la interfaz de usuario

public class ActualizarTexto : MonoBehaviour
{
    public Text  miTexto;
    int numTexto = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //realizamos una accion cuando alguien presiona una tecla
        if (Input.GetKeyDown(KeyCode.Space))
        {
            numTexto++;//aumenta a medida de que aumentan las entradas de la tecla
            miTexto.text = numTexto.ToString();
        } else if(Input.GetKeyDown(KeyCode.S)){
            miTexto.text = "S fue presionada";
        }
    }
}
