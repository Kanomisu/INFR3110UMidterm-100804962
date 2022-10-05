using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    //BPM of the Audio clip
    private int audioSpeed = 100;
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            AudioManager.instance.ChangeSpeed(audioSpeed);
            Destroy(gameObject);
        }
    }
}
