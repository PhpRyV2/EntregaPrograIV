using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] //SIEMPRE QUE QUERAMOS CONVERTIR UNA CLASE A JSON NECESITA EL ATRIBUTO SERIALIZABLE
public class PjSheet
{
    public string   pJName;
    public string   pJClass;
    public int      lvl;
    public int      hp;
    public int      str;
    public int      dex;
    public int      con;
    public int      inte;
    public int      wis;
    public int      cha;

    public PjSheet(PJSheetStruct pjSheetStruct)
    {
        pJName    = pjSheetStruct.pJName;
        pJClass     = pjSheetStruct.pJClass;
        lvl     = pjSheetStruct.lvl;
        hp      = pjSheetStruct.hp;
        str     = pjSheetStruct.str;
        dex     = pjSheetStruct.dex;
        con     = pjSheetStruct.con;
        inte    = pjSheetStruct.inte;
        wis     = pjSheetStruct.wis;
        cha      = pjSheetStruct.cha;

        //ocupamos this para decir cual es la variable global de la clase
    }
}

public struct PJSheetStruct
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

    public PJSheetStruct(string pJName, string pJClass, int lvl, int hp, int str, int dex, int con, int inte, int wis, int cha)
    {
        this.pJName = pJName;
        this.pJClass = pJClass;
        this.lvl = lvl;
        this.hp = hp;
        this.str = str;
        this.dex = dex;
        this.con = con;
        this.inte = inte;
        this.wis = wis;
        this.cha = cha;

    }
}
