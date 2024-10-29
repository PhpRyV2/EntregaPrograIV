using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharactersJSON : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Name, Class, Lvl, HP, Str, Con, Mag, Res, Dex, Acc, Avo, Lck;
    //Hay un json en la carpeta Resources que tiene los stats pero dejé esto modo mono pq me quedé sin tiempo xdd
    public void Shen()
    {
        Name.text = "Shen";
        Class.text = "Berserker";
        Lvl.text = "1";
        HP.text = "12";
        Str.text = "14";
        Con.text = "16";
        Mag.text = "8";
        Res.text = "12";
        Dex.text = "10";
        Acc.text = "2";
        Avo.text = "10";
        Lck.text = "1";
    }

    public void Breni()
    {
        Name.text = "Breni";
        Class.text = "Assassin";
        Lvl.text = "1";
        HP.text = "10";
        Str.text = "8";
        Con.text = "12";
        Mag.text = "10";
        Res.text = "14";
        Dex.text = "16";
        Acc.text = "2";
        Avo.text = "13";
        Lck.text = "2";
    }

    public void Kenji()
    {
        Name.text = "Kenji";
        Class.text = "Shadow Poet";
        Lvl.text = "1";
        HP.text = "9";
        Str.text = "8";
        Con.text = "12";
        Mag.text = "16";
        Res.text = "14";
        Dex.text = "10";
        Acc.text = "2";
        Avo.text = "10";
        Lck.text = "1";
    }
}
