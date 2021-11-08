using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_StateBar : FindMG
{
    public Text T_hp;
    public Image I_hpfill;

    public Text T_Score;
    public Text T_uiScore;

    private void Update()
    {
        HPrefresh();
        Scorefresh();
    }

    void HPrefresh()
    {
        I_hpfill.fillAmount = PS.HP / PS.MaxHP;
        T_hp.text = "HP:" + PS.HP+"/"+PS.MaxHP;

    }

    void Scorefresh()
    {
        T_Score.text = "SCORE:" + GM.Score.ToString();
        if (T_uiScore)
        {
            T_uiScore.text = T_Score.text;
        }
    }

}
