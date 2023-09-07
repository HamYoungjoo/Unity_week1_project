using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public Text PlayerNameTxt;

    // Start is called before the first frame update
    void Start()
    {
        string playerName = PlayerPrefs.GetString("PlayerName", "DefaultName"); // "DefaultName"은 기본값

        if (PlayerNameTxt != null)
        {
            PlayerNameTxt.text = ($"{playerName}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
