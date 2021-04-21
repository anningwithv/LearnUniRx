using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
    IEnumerator CoroutineA()
    {
        yield return new WaitForSeconds(1.0f);
        Debug.Log("A 1");
        yield return new WaitForSeconds(2.0f);
        Debug.Log("A 2");
    }
    IEnumerator CoroutineB()
    {
        yield return new WaitForSeconds(2.0f);
        Debug.Log("B");
    }

    void Start()
    {
        var aStream = Observable.FromCoroutine(CoroutineA);
        var bStream = Observable.FromCoroutine(CoroutineB);

        Observable.WhenAll(aStream, bStream)
        .Subscribe(_ => Debug.Log("On all coroutine end")).
        AddTo(this);
    }
}
