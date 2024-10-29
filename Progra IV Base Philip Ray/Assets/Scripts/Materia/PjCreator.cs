using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class PjCreator : MonoBehaviour
{
    public string pJName;
    public string pJClass;
    public int lvl;
    public int hp;
    public int str;
    public int dex;
    public int con;
    public int inte;
    public int wis;
    public int cha;
    public int slot;

    [SerializeField] TMPro.TMP_InputField if_Name;
    [SerializeField] TMPro.TMP_InputField if_Level;
    [SerializeField] TMPro.TMP_Dropdown   if_Class;
    [SerializeField] TMPro.TMP_InputField if_HP;
    [SerializeField] TMPro.TMP_InputField if_Str;
    [SerializeField] TMPro.TMP_InputField if_Dex;
    [SerializeField] TMPro.TMP_InputField if_Con;
    [SerializeField] TMPro.TMP_InputField if_Int;
    [SerializeField] TMPro.TMP_InputField if_Wis;
    [SerializeField] TMPro.TMP_InputField if_Cha;
    [SerializeField] TMPro.TMP_Dropdown LoadSlot;

    private void Awake()
    {
        if_Name.onValueChanged.AddListener(NameValueChanged);
        if_Level.onValueChanged.AddListener(LevelValueChanged);
        if_Class.onValueChanged.AddListener(ClassValueChanged);
        if_HP.onValueChanged.AddListener(HPValueChanged);
        if_Str.onValueChanged.AddListener(StrValueChanged);
        if_Dex.onValueChanged.AddListener(DexValueChanged);
        if_Con.onValueChanged.AddListener(ConValueChanged);
        if_Int.onValueChanged.AddListener(IntValueChanged);
        if_Wis.onValueChanged.AddListener(WisValueChanged);
        if_Cha.onValueChanged.AddListener(ChaValueChanged);
    }

    private void Start()
    {
        PopulateDropdown();
    }

    private void ChaValueChanged(string val)
    {
        int.TryParse(val, out cha);
    }

    private void WisValueChanged(string val)
    {
        int.TryParse(val, out wis);
    }

    private void IntValueChanged(string val)
    {
        int.TryParse(val, out inte);
    }

    private void ConValueChanged(string val)
    {
        int.TryParse(val, out con);
    }

    private void DexValueChanged(string val)
    {
        int.TryParse(val, out dex);
    }

    private void StrValueChanged(string val)
    {
        int.TryParse(val, out inte);
    }

    private void HPValueChanged(string val)
    {
        int.TryParse(val, out hp);
    }

    private void LevelValueChanged(string val)
    {
        int.TryParse(val,out lvl);
    }

    private void ClassValueChanged(int val)
    {
        pJClass = if_Class.options[val].text;
    }

    private void NameValueChanged(string val)
    {
        pJName = val;
    }


    public void Save()
    {
        slot = LoadSlot.value;
        SaveSystem saveSyste = new SaveSystem();
        PJSheetStruct pJSheetStruct = new PJSheetStruct(pJName, pJClass, lvl, hp, str, dex, con, inte, wis, cha);
        saveSyste.SavePjSheet(pJSheetStruct, slot);
        Debug.Log("Save Successful");
    }


    public void PopulateDropdown()
    {
        int totalSlots = 8;
        for (int i = 0; i < totalSlots; i++)
        {
            LoadSlot.options.Add(new TMP_Dropdown.OptionData("Slot " + i));
        }

        LoadSlot.RefreshShownValue();
    }

    public void Load()
    {
        int slot = LoadSlot.value;
        Debug.Log("Data Loaded");
        SaveSystem saveSystem = new SaveSystem();
        PjSheet pjSheet = saveSystem.LoadPJSheet(slot);
        pJName = pjSheet.pJName;
        pJClass = pjSheet.pJClass;
        lvl = pjSheet.lvl;
        hp = pjSheet.hp;
        str = pjSheet.str;
        dex = pjSheet.dex;   
        con = pjSheet.con;   
        inte = pjSheet.inte;
        wis = pjSheet.wis;
        cha = pjSheet.cha;

        if_Name.text = pjSheet.pJName;
        if_Level.text = pjSheet.lvl.ToString();
        if_Class.options[if_Class.value].text = pjSheet.pJClass;
        if_HP.text = pjSheet.hp.ToString();
        if_Str.text = pjSheet.str.ToString();
        if_Dex.text = pjSheet.dex.ToString();
        if_Con.text = pjSheet.con.ToString();
        if_Int.text = pjSheet.inte.ToString();
        if_Wis.text = pjSheet.wis.ToString();
        if_Cha.text = pjSheet.cha.ToString();
    }

}
