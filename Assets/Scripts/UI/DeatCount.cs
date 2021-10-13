using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeatCount : MonoBehaviour
{
    public TMP_Text textCount;

    private int contador = 0;

    private void Awake()
    {
        
    }

    public void updateDeath(int death)
    {
        contador = death;
        textCount.text = "DEATHS: " + contador;
    }
}
