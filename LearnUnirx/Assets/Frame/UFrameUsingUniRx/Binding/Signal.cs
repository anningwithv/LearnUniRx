using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class Signal<TClass> : ISubject<TClass>, ISignal where TClass : ViewModelCommand, new()
{
    private readonly ViewModel m_ViewModel;
    private Action<TClass> m_Action;

    public Signal(ViewModel viewModel)
    {
        m_ViewModel = viewModel;
    }

    #region ISignal
    public Type SignalType => throw new NotImplementedException();

    public void Publish(object data)
    {
    }

    public void Publish()
    {
    }


    #endregion

    #region ISubject
    public void OnCompleted()
    {
    }

    public void OnError(Exception error)
    {
    }

    public void OnNext(TClass value)
    {
    }

    public IDisposable Subscribe(IObserver<TClass> observer)
    {
        return null;
    }
    #endregion


}
