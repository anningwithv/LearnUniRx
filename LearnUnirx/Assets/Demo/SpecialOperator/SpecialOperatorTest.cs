using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

public class SpecialOperatorTest : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Current frame: " + Time.frameCount);

        var clickStream = this.UpdateAsObservable().Where(_ => Input.GetMouseButtonDown(0));

        // 1.NextFrame 隔一帧执行
        Observable.NextFrame()
            .Subscribe(_ => Debug.Log("Next frame:" + Time.frameCount));

        // 2.DelayFrame 延迟几帧执行
        Observable.ReturnUnit()
            .DelayFrame(3)
            .Subscribe(_ => Debug.Log("Delay 4 frame:" + Time.frameCount));

        //// 3.RepeatUntilDestroy 重复执行，直到被destroy
        //Observable.Timer(TimeSpan.FromSeconds(1.0f))
        //    .RepeatUntilDestroy(this)
        //    .Subscribe(_ => Debug.Log("RepeatUntilDestroy: ticked" + Time.time));

        //// 4.RepeatUntilDisable 重复执行，直到被disable
        //Observable.Timer(TimeSpan.FromSeconds(1.0f))
        //    .RepeatUntilDisable(this)
        //    .Subscribe(_ => Debug.Log("RepeatUntilDisable: ticked" + Time.time));

        // 5.Interval 每隔一段时间执行一次
        //Observable.Interval(TimeSpan.FromSeconds(2)).Subscribe(count =>
        //{
        //    Debug.LogFormat("当前Count:{0}", count + "     " + Time.time);
        //}).AddTo(this);

        // 6.TakeUntil 一直执行直到某个条件完成
        //this.UpdateAsObservable()
        //     .TakeUntil(Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0)))
        //     .Subscribe(_ =>
        //     {
        //         Debug.Log("TakeUntil" + Time.time);
        //     });

        // 7.SkipUntil
        //this.UpdateAsObservable()
        //    .SkipUntil(clickStream)
        //    .Subscribe(_ => Debug.Log("⿏标按过了"));

        // 8.Delay
        //Observable.EveryUpdate()
        //     .Where(_ => Input.GetMouseButtonDown(0))
        //     .Delay(TimeSpan.FromSeconds(1.0f))
        //     .Subscribe(_ => { Debug.Log("mouse clicked"); })
        //     .AddTo(this);

        // 9.Timer
        //Observable.Timer(TimeSpan.FromSeconds(2.0f))
        // .Subscribe(_ => { Debug.Log("after 2 seconds"); })
        // .AddTo(this);

    }
}
