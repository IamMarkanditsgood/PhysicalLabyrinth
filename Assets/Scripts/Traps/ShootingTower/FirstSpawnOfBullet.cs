using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstSpawnOfBullet : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private int _numberOfBullets;

    private void Start()
    {
        for (int i = 0; i < _numberOfBullets; i++)
        {
            ObjectSpawn();
        }
    }

    public void ObjectSpawn()
    {
        GameObject obj = Instantiate(_bullet);
        obj.SetActive(false);
        BulletsStorey.Instance.PooledBullets = obj;
    }
}
