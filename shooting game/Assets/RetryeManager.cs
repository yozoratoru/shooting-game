using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryeManager : MonoBehaviour
{
    public void Retry()
    {
        // scoreに移動する
        SceneManager.LoadScene("SampleScene");
    }
}