using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class PlayerInfoViewModel : ViewModel
{
    public IntReactiveProperty level;
    public StringReactiveProperty name;
    public IntReactiveProperty hp;

    public Action<string> onNameChanged;
}
