using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using System;

public class PlayerInfoView : MonoBehaviour
{
    [SerializeField] private Text m_NameText = null;
    [SerializeField] private Button m_ChangeNameBtn = null;
    [SerializeField] private InputField m_NameInputField = null;

    private PlayerInfoViewModel m_ViewModel = null;

    public void Init(PlayerInfoViewModel viewModel)
    {
        m_ViewModel = viewModel;

        Bind();
    }

    private void Bind()
    {
        m_ViewModel.name.SubscribeToText(m_NameText);
        m_ChangeNameBtn.OnClickAsObservable().
            Subscribe(_ =>
            {
                m_ViewModel.onNameChanged.Invoke(m_NameInputField.text);
            });
    }
}
