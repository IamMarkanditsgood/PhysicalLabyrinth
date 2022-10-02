using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelData : MonoBehaviour
{
    public static LevelData Instanke;
    [SerializeField] private int _levelScore;
    private void Awake()
    {
        Instanke = this;
    }
    public int LevelScore{ get { return _levelScore; } set { _levelScore = value; } }    
}
