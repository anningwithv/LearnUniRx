using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class ReactiveCollectionTest : MonoBehaviour
{
    ReactiveCollection<int> mAges = new ReactiveCollection<int> { 1,2,3,4,5};

    void Start()
    {
        mAges.ObserveAdd()
         .Subscribe(addAge => {
             Debug.LogFormat("add:{0}", addAge);
         });

        mAges.ObserveRemove()
         .Subscribe(removedAge => {
             Debug.LogFormat("remove:{0}", removedAge);
         });

        mAges.ObserveCountChanged()
         .Subscribe(count => {
             Debug.LogFormat("count:{0}", count);
         });

        mAges.Add(6);
        mAges.Remove(2);
    }
}
