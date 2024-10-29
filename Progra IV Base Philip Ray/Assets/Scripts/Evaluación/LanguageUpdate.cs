using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

[RequireComponent(typeof(GameObject))]
public class LanguageUpdate : MonoBehaviour
{
    
    public LanguageManager manager;
    [SerializeField] TextMeshProUGUI text;
    // Start is called before the first frame update
    private void Awake()
    {
        manager.OnLanguageChangeAddListener(OnLanguageChange);
        //manager.LanguageChange(2);
    }

    public void OnLanguageChange(Dictionary<string,string> _dict)
    {
        text.text = _dict[gameObject.name];
        //text.text = _dict[key];
        //Debug.Log("name of stat1 is " + _dict["stat1"]);
    }
}
