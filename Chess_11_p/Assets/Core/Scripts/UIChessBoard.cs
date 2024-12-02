using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class UIChessBoard : MonoBehaviour
{
    [Header("p1")]
    public TextMeshProUGUI cooldownP1;
    public GameObject buttonP1;
    public GameObject portraitP1;
    public GameObject degradadoP1;
    [Header("p2")]
    public TextMeshProUGUI cooldownP2;
    public GameObject buttonP2;
    public GameObject portraitP2;
    public GameObject degradadoP2;
    [Header("general")]
    public GenerateBoard cB;
    public MovimientoPiezas mPiezas;
    public int p1Team;
    public int p2Team;
    public bool pausa;
    public Sprite[] AbilityIcons;
    public Sprite[] CharacterIcons;
    public GameObject pausaPanel;

    private void Awake()
    {
        pausa = false;
    }
    public void DisableButton(bool p1)
    {
        if (p1)
        {
            buttonP2.SetActive(false);
        }
        else
        {
            buttonP1.SetActive(false);
        }
    }
    public void UniversalIndex()
    {
        buttonP1.GetComponent<Image>().sprite = AbilityIcons[p1Team];
        buttonP2.GetComponent<Image>().sprite = AbilityIcons[p2Team];

        portraitP1.GetComponent<Image>().sprite = CharacterIcons[p1Team];
        portraitP2.GetComponent<Image>().sprite = CharacterIcons[p2Team];


    }
    public void SwapSides()
    {
        if(mPiezas.p1Turn)
        {
            degradadoP2.SetActive(true);

            degradadoP1.SetActive(false);
        }
        else
        {
            

            degradadoP1.SetActive(true);

            degradadoP2.SetActive(false);

        }
    }
    public void UpdateUI()
    {
        UpdateCooldowns();
        SwapSides();
    }
    private void Start()
    {
      
        
        UpdateCooldowns();
        p1Team = cB.p1T - 1;
        p2Team = cB.p2T - 1;
        UniversalIndex();
    }

    private void UpdateCooldowns()
    {
        cooldownP1.text = cB.p1Cd.ToString();
        cooldownP2.text = cB.p2Cd.ToString();
    }
    public void Pause()
    {
        if(!pausa)
        {
            pausaPanel.SetActive(true);
            pausa = true;
        }
        else
        {
            UnPause();
        }
        
    }
    public void UnPause()
    {
        pausaPanel.SetActive(false);
        pausa = false;
    }
}
