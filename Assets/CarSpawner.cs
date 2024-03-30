using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject[] Cars;
    public Transform CarSpawnPoint;

    private void Start()
    {
        switch (PlayerPrefs.GetInt("Car"))
        {
            case 1:
                Instantiate(Cars[0], CarSpawnPoint.position, CarSpawnPoint.rotation);
                break;
            case 2:
                Instantiate(Cars[1], CarSpawnPoint.position, CarSpawnPoint.rotation);
                break;
            case 3:
                Instantiate(Cars[2], CarSpawnPoint.position, CarSpawnPoint.rotation);
                break;
        }
    }
}
