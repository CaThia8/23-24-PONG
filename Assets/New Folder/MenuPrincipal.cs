using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void Cargar1Jugador()
    {
        Debug.Log("Cargando 1 jugador");
        SceneManager.LoadScene("1jugador");
    }
    public void Cargar2Jugadores()
    {
        Debug.Log("Cargando 2 jugadores");
        SceneManager.LoadScene("2Jugadores");
    }
}

