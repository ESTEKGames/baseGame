using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FinishGame : MonoBehaviour
{
    public GameObject text;
    public AudioListener listener;

    private void OnTriggerEnter(Collider other)
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        text.SetActive(true);
        Time.timeScale = 0;
        listener.enabled = false;
    }
}
