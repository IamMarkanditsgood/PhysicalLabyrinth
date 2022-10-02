using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    [SerializeField] private float _restartimer;
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private Animator _animator;
    private Coroutine _coroutine;

    private void OnEnable()
    {
        _coroutine = StartCoroutine(RestartSpikes(_restartimer, _gameObject));
    }

    private void OnDisable()
    {
        StopCoroutine(_coroutine);
    }

    private IEnumerator RestartSpikes(float time, GameObject gameObject)
    {
        while(true)
        {
                gameObject.SetActive(false);
                _animator.Play("SpikeMoveDown", 0, 0.0f);
            yield return new WaitForSeconds(time);

                gameObject.SetActive(true);
                _animator.Play("SpikeMoveUp", 0, 0.0f);
            yield return new WaitForSeconds(time);
        }
    }

    private void OnDestroy()
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }
    }
}
