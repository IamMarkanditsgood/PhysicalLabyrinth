using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTimer : MonoBehaviour
{
    [SerializeField] private float _timeLife;
    private Coroutine _coroutine;

    private void OnEnable()
    {
        _coroutine = StartCoroutine(WaitDeath(_timeLife));
    }

    private void OnDisable()
    {
        StopCoroutine(_coroutine);
    }

    private IEnumerator WaitDeath(float timeLife)
    {
        yield return new WaitForSeconds(timeLife);
        gameObject.SetActive(false);
    }

    private void OnDestroy()
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }
    }
}
