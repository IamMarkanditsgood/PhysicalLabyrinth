using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private float _shootingTime;
    [SerializeField] private Transform _startPosition;
    private bool _isShoot;
    private Coroutine _coroutine;

    private void Update()
    {
        ShootFromGun();
    }
    private void OnEnable()
    {
        _coroutine = StartCoroutine(ShootingTimer(_shootingTime));
    }

    private void OnDisable()
    {
        StopCoroutine(_coroutine);
    }
    private void OnDestroy()
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }
    }
    /*private IEnumerator ShootingTimer(float time, Transform position, GameObject pooledObject)
    {
        while(true)
        {
            print("good");
            GameObject obj = pooledObject;
            obj.transform.position = position.position;
            obj.transform.rotation = position.rotation;
            obj.SetActive(true);
            yield return new WaitForSeconds(time);
        }
    }*/
    private IEnumerator ShootingTimer(float time)
    {
        while (true)
        {
            _isShoot = true;
            yield return new WaitForSeconds(time);
        }
    }
    private void ShootFromGun()
    {
        if (_isShoot)
        {
            GameObject obj = BulletsStorey.Instance.PooledBullets;
            obj.transform.position = _startPosition.position;
            obj.transform.rotation = _startPosition.rotation;
            obj.SetActive(true);
            _isShoot = false;
        }
    }
}
