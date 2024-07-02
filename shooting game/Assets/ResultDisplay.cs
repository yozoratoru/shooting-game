using UnityEngine;
using UnityEngine.UI;

public class ResultDisplay : MonoBehaviour
{
    public Text resultText;

    void Start()
    {
        float finalTime = PlayerPrefs.GetFloat("FinalTime");
        resultText.text = "Your Time: " + finalTime.ToString("F2") + " seconds";
    }
}

