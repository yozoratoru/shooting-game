using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // クリックカウント用の変数
    private int clickCount = 0;

    // 更新処理
    void Update()
    {
        // 左クリックが押されたとき
        if (Input.GetMouseButtonDown(0))
        {
            // クリックカウントを増加
            clickCount++;

            // クリックカウントが20に達したらシーンを変更
            if (clickCount >= 20)
            {
                // 移動したいシーンの名前またはインデックスを指定
                SceneManager.LoadScene("sukoahyouji"); // "NextScene" を実際のシーン名に置き換えてください
            }
        }
    }
}
