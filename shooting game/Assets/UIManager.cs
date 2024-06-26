using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public GameObject endGamePanel; // 終了時に表示するパネル

    public void DisplayFinalScore()
    {
        scoreText.text = "Final Score: " + PlayerPrefs.GetInt("FinalScore", 10);;
        endGamePanel.SetActive(true); // パネルを表示
    }
}
