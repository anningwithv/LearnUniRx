using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISignal
{
    Type SignalType { get; }
    void Publish(object data);
    void Publish();
}
