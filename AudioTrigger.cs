using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    [SerializeField] string soundName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Trigger");
        if (collision.CompareTag("Player"))
        {
            //Put audio Code Here
            print("PlayerTagged");
        }
    }
}
