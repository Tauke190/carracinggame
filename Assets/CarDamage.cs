using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDamage : MonoBehaviour
{

    public GameObject[] carparts;

    private void Start()
    {
        int crashes = PlayerPrefs.GetInt("Car1_Crash");

        switch(crashes)
        {
            case 1:
                carparts[0].SetActive(false);
                break;
            case 2:
                carparts[0].SetActive(false);
                carparts[1].SetActive(false);
                break;
            case 3:
                break;
                carparts[0].SetActive(false);
                carparts[1].SetActive(false);
                carparts[2].SetActive(false);
        }

    }
}