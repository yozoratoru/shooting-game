using UnityEngine;

public class ObjectCollisionDetector : MonoBehaviour
{
    public TimerManager timerManager;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ao") || 
            collision.gameObject.CompareTag("kiiro") || 
            collision.gameObject.CompareTag("kuro"))
        {
            timerManager.IncrementObjectCount();
        }
    }
}

