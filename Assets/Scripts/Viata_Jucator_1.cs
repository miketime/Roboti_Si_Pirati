//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Viata_Jucator_1 : MonoBehaviour
{
    public static int viataActuala = 0;
    public int maxHp = 100;
    public Slider healthBar;
    private void Start()
    {
        viataActuala = maxHp;
        healthBar.value = viataActuala;
        healthBar.maxValue = maxHp;

    }
    private void Update()
    {
        if (viataActuala <= 0)
        {
            SceneManager.LoadScene(1);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            DamagePlayer(10);
        }
    }

    public void DamagePlayer(int v)
    {
        viataActuala -= v;
        healthBar.value = viataActuala;
    }
}
