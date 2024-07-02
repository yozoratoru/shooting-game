using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerManager : MonoBehaviour
{
    public Text timerText; // タイムを表示するUIテキスト
    private float startTime;
    private bool timerRunning = false;
    private int objectCount = 0;
    public int targetObjectCount = 11; // 目標のオブジェクト数

    void Update()
    {
        if (timerRunning)
        {
            float timeElapsed = Time.time - startTime;
            timerText.text = timeElapsed.ToString("F2") + " seconds";
        }

        // 左クリックでタイマー開始
        if (Input.GetMouseButtonDown(0) && !timerRunning)
        {
            StartTimer();
        }
    }

    public void StartTimer()
    {
        startTime = Time.time;
        timerRunning = true;
    }

    public void StopTimer()
    {
        timerRunning = false;
        float finalTime = Time.time - startTime;
        PlayerPrefs.SetFloat("FinalTime", finalTime); // タイムを保存
        SceneManager.LoadScene("taimhyouji"); // 結果を表示するシーンに移動
    }

    public void IncrementObjectCount()
    {
        objectCount++;
        if (objectCount >= targetObjectCount)
        {
            StopTimer();
        }
    }
}

