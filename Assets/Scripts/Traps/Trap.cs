using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
           PlayerDeath.instanke.Death();
        }

    }

}
