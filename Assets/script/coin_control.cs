using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;    // 記得加這行
using TMPro;             // 記得加這行

public class coin_control : MonoBehaviour 
{
    int current_money;
    //public Text playerMoney;

    void Update ()
    {
          current_money = PlayerPrefs.GetInt("Wallet_Money"); //讀取PlayerPrefs存取的數值(""中為標籤名稱)
          GetComponent<TextMeshProUGUI>().text = "" + current_money; //將數值印出
    }
}
