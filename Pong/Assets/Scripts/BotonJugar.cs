﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BotonJugar : MonoBehaviour
{
    // Start is called before the first frame update
   public void IrAlJuego()
    {
        SceneManager.LoadScene("Juego");
    }
}