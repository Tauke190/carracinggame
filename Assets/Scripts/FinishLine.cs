using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{

    private void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("Car"))
        {
            GameManager.instance.Lap += 1;
            GameManager.instance.PlayLapSound();
            StartCoroutine(ActivateCollider());
            return;
        }
    }

    private IEnumerator ActivateCollider()
    {
        
        GetComponent<Collider>().enabled = false;
        yield return new WaitForSeconds(2f);
        GetComponent<Collider>().enabled = true;

    }
}
