using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginPanel : MonoBehaviour
{
    [SerializeField] TMPro.TMP_InputField iF_UserName;
    [SerializeField] TMPro.TMP_InputField iF_Mail;
    [SerializeField] TMPro.TMP_InputField iF_Pass;

    [SerializeField] Button butt_Login;
    public delegate void OnLoginPressed(string mail, string pass, bool toggleOn);
    OnLoginPressed onLoginPressed;

    string mail;
    string pass;

    [SerializeField] Toggle toggle;
    bool toggleOn;

    private void Awake()
    {
        iF_Mail.onValueChanged.AddListener(ChangeMail);
        iF_Pass.onValueChanged.AddListener(ChangePass);
        butt_Login.onClick.AddListener(OnButtonLoginPressed);
    }

    private void ToggleChange(bool val)
    {
        toggleOn = val;
    }

    private void ChangeMail(string val)
    {
        mail = val;
    }

    private void ChangePass(string val)
    {
        pass = val;
    }

    public void OnButtonLoginPressed()
    {
        onLoginPressed?.Invoke(mail, pass, toggleOn);
    }

    public void AddListenerToOnLoginPressed(OnLoginPressed listener)
    {
        onLoginPressed += listener;
    }

    public void RemoveListenerToOnLoginPressed(OnLoginPressed listener)
    {
        onLoginPressed -= listener;
    }

}
