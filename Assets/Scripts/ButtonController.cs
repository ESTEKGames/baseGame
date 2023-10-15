using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public void Cikis()
    {
        Application.Quit();
    }

    public void CursorControl()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }
}
