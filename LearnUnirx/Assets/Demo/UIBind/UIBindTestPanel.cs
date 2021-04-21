using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UniRx.Triggers;

public class UIBindTestPanel : MonoBehaviour
{
    [SerializeField] private Button m_Btn1;
    [SerializeField] private InputField m_InputField1;
    [SerializeField] private Text m_Text1;
    [SerializeField] private Image m_Image1;

    private void Start()
    {
        m_Btn1.OnClickAsObservable().Subscribe((value) => {
            Debug.Log("On btn1 clicked: " + value);
        });

        //m_InputField1.OnEndEditAsObservable().SubscribeToText(m_Text1);
        m_InputField1.OnValueChangedAsObservable().SubscribeToText(m_Text1);

        m_Image1.OnBeginDragAsObservable().Subscribe(_ => { Debug.Log("On image dragged"); });
    }
}
