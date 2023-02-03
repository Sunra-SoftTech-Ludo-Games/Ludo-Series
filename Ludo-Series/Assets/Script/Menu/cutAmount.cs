using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class cutAmount : MonoBehaviour
{
   
    int amonut;
    public TMP_Text entryFees;
    private void OnEnable()
    {
        entryFees.text = GameManager.Instance.payoutCoins.ToString();
    }
   
    public void BclickAmt()
    {      

        amonut = GameManager.Instance.payoutCoins;

        PlayerPrefs.SetString("bidamount", amonut.ToString());
        PlayerPrefs.Save();

        TotalJoinedPlayerEvents.Instance.SaveData();

        ShowGameConfiguration(GameManager.Instance.numberOfTotalPlayers);

        GameManager.Instance.EnterEvents = true;
        GameManager.Instance.JoinEvents = true;

        GameManager.Instance.eventIdsBT.Add(GameManager.Instance.eventIDs);
    }

    void ShowGameConfiguration(int index)
    {
        GameManager.Instance.showTargetLines = true;

        GameManager.Instance.mode = MyGameMode.Master;

        switch (index)
        {
            case 2:
                GameManager.Instance.type = MyGameType.TwoPlayer;
                Debug.Log(GameManager.Instance.type);
                break;

            case 4:
                GameManager.Instance.type = MyGameType.FourPlayer;
                Debug.Log(GameManager.Instance.type);
                break;

        }
       
    }


   
}
