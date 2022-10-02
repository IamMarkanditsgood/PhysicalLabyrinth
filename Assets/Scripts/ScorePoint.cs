using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            LevelData.Instanke.LevelScore++;
            print(LevelData.Instanke.LevelScore);
            Destroy(gameObject);
        }

    }
}
