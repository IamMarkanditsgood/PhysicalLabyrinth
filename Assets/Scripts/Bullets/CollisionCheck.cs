using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.layer != LayerMask.NameToLayer("Player"))
        {

            gameObject.SetActive(false);
        }

    }
}
