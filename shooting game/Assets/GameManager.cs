using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // スコアを管理するためのインスタンス
    private static GameManager _instance;
    public static GameManager Instance { get { return _instance; } }

    // 現在のスコア
    private int score = 0;

    // 初期化
    private void Awake()
    {
        // シングルトンパターンの実装
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    // スコアを増やす関数
    public void AddScore(int value)
    {
        score += value;

        // スコアが更新されたことをUIに通知
        //FindObjectOfType<ScoreManager>().UpdateScore(score);
    }

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 90;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
