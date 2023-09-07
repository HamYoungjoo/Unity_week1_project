using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InputName : MonoBehaviour
{
    public InputField NameInputField; // 이름을 입력받을 InputField

    private void Start()
    {
        Button joinButton = NameInputField.transform.Find("JoinBtn").GetComponent<Button>();
        joinButton.onClick.AddListener(Enterance);

    }

    public void Enterance()
    {
        // 입력된 이름을 가져오고 공백 제거
        string playerName = NameInputField.text.Trim();

        // 이름이 비어 있지 않다면 다음 씬으로 이동
        if (!string.IsNullOrEmpty(playerName))
        {
            PlayerPrefs.SetString("PlayerName", playerName);
            SceneManager.LoadScene("MainScene");
        }
    }
}
