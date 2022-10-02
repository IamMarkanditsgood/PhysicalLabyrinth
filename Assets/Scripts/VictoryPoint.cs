using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            print("vin");
            Destroy(other.gameObject);
            Time.timeScale = 0f;
        }
       
    }
}
