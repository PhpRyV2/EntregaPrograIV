using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginMenuManager : MonoBehaviour
{
    LoginPanel loginPanel;
    PanelCreateUSer panelCreateUSer;

    private void Awake()
    {
        loginPanel.AddListenerToOnLoginPressed(OnLogin);
        panelCreateUSer.AddListenerToOnCreatePressed(OnCreate);
    }

    void OnLogin(string username, string password, bool toggleOn)
    {

    }

    void OnCreate(string username, string mail, string pass,string repeatPass)
    {

    }

    private void OnDestroy()
    {
        loginPanel.RemoveListenerToOnLoginPressed(OnLogin);
        panelCreateUSer.RemoveListenerToOnCreatePressed(OnCreate);
    }
}
