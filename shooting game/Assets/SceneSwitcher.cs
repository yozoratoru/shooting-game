using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitcher : MonoBehaviour
{
    public Button myButton; // インスペクターでボタンを割り当てる
    public string sceneName; // 切り替え先のシーン名

    void Start()
    {
        if (myButton == null)
        {
            Debug.LogError("myButton is not assigned.");
            return;
        }

        // ボタンにリスナーを追加して、クリックされたときにシーンを切り替える
        myButton.onClick.AddListener(SwitchScene);
    }

    void SwitchScene()
    {
        Debug.Log(sceneName);
        if (string.IsNullOrEmpty(sceneName))
        {
            Debug.LogError("sceneName is not assigned.");
            return;
        }

        // シーンを切り替える
        SceneManager.LoadScene(sceneName);
    }
}
