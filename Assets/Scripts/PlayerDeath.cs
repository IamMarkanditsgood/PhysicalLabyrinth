using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public static PlayerDeath instanke;

    private void Awake()
    {
        instanke = this;
    }

    public void Death()
    {
        print("Losser");
        Destroy(gameObject);
        Time.timeScale = 0f;
    }
}
