using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfoController
{
    private PlayerInfoViewModel m_ViewModel;

    public void Initialize(PlayerInfoViewModel viewModel)
    {
        m_ViewModel = viewModel;
    }
}
