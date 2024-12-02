using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class MenuVictoria : MonoBehaviour
{
    public Sprite[] Campeon;
    public string[] NombreC;
    public Image HeroeP;
    public TextMeshProUGUI NombreUI;
    public GameObject Panel;
    
    public void SpawnPanel(bool p1, int equipoGanador)
    {
        int equipoIndice = equipoGanador -1;
        int jugadorGanador;
        Panel.SetActive(true);

        if (p1 == true)
        {
            
            jugadorGanador = 0;
            HeroeP.sprite = Campeon[equipoIndice];
            NombreUI.text = NombreC[jugadorGanador];
            Debug.Log("equipo ganador");
            Debug.Log(equipoGanador);
            Debug.Log("jugador ganador");
            Debug.Log(jugadorGanador);
        }
        else
        {
            jugadorGanador = 1;
            HeroeP.sprite = Campeon[equipoIndice];
            NombreUI.text = NombreC[jugadorGanador];
            Debug.Log("equipo ganador");
            Debug.Log(equipoGanador);
            Debug.Log("jugador ganador");
            Debug.Log(jugadorGanador);
        }

    }
    
    
}
