using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelCreateUSer : MonoBehaviour
{
    [SerializeField] TMPro.TMP_InputField iF_UserName;
    [SerializeField] TMPro.TMP_InputField iF_Mail;
    [SerializeField] TMPro.TMP_InputField iF_Pass;
    [SerializeField] TMPro.TMP_InputField iF_RepeatPass;

    [SerializeField] Button butt_Create;
    public delegate void OnCreatePressed(string username, string mail, string pass, string repeatPass);
    OnCreatePressed onCreatePressed;

    string userName;
    string mail;
    string pass;
    string repeatPass;

    private void Awake()
    {
        iF_UserName.onValueChanged.AddListener(ChangeUserName);
        iF_Mail.onValueChanged.AddListener(ChangeMail);
        iF_Pass.onValueChanged.AddListener(ChangePass);
        iF_RepeatPass.onValueChanged.AddListener(ChangeRepeatPass);
        butt_Create.onClick.AddListener(OnButtonCreatePressed);
    }

    private void ChangeRepeatPass(string val)
    {
        repeatPass = val;
    }

    private void ChangeMail(string val)
    {
        mail = val;
    }

    private void ChangeUserName(string val)
    {
        userName = val;
    }

    private void ChangePass(string val)
    {
        pass = val;
    }

    public void OnButtonCreatePressed()
    {
        onCreatePressed?.Invoke(userName,mail, pass, repeatPass);
    }

    public void AddListenerToOnCreatePressed(OnCreatePressed listener)
    {
        onCreatePressed += listener;
    }
    
    public void RemoveListenerToOnCreatePressed(OnCreatePressed listener)
    {
        onCreatePressed -= listener;
    }

}
