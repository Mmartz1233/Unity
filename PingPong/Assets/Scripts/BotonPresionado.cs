using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;//administrador de escenas

public class BotonPresionado : MonoBehaviour
{

    public void CambiarDeEscena(int escenaId)
    {
        SceneManager.LoadScene(escenaId);//cambiamos de escena
    
    }
   
}
