using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botones : MonoBehaviour
{
    public GameObject menuPausa;
    public GameObject botonPausa;
    public GameObject botonContinuar;
    public bool IsPaused;

    public void Start()
    {
        menuPausa.SetActive(false);
        IsPaused = false;
        Time.timeScale = 1;
    }
    public void PausarJuego()
    {
        menuPausa.SetActive(true);
        IsPaused = true;
        Time.timeScale = 0;
    }
    public void ContinuarJuego()
    {
        menuPausa.SetActive(false);
        IsPaused = false;
        Time.timeScale = 1;
    }
    public void SalirDelJuego()
    {
        Application.Quit();
        Debug.Log("Saliste del juego");
    }
}
