using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class DelayTest : MonoBehaviour
{

    private void Start()
    {
        float delayTime = 1f;

        Observable.Timer(TimeSpan.FromSeconds(delayTime))
            .Subscribe(_ => { Debug.Log("On Time Over");})
            .AddTo(this);
    }
}
