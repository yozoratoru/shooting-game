using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryManager : MonoBehaviour
{
    public void Retry()
    {
        // scoreに移動する
        SceneManager.LoadScene("score");
    }
}