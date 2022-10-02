using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletsStorey : MonoBehaviour
{
    public static BulletsStorey Instance { get; private set; }
    [SerializeField] private List<GameObject> _bullets = new List<GameObject>();
    private void Awake()
    {
        Instance = this;
    }
    public GameObject PooledBullets
    {
        get
        {
            for (int i = 0; i < _bullets.Count; i++)
            {
                if (!_bullets[i].activeInHierarchy)
                {

                    return _bullets[i];
                }
            }
             FirstSpawnOfBullet firstSpawnOfBullet = gameObject.GetComponent<FirstSpawnOfBullet>();
            firstSpawnOfBullet.ObjectSpawn();
            int _lastObjectInList = _bullets.Count - 1;
            return _bullets[_lastObjectInList];
        }
        set { _bullets.Add(value); }
    }
}
