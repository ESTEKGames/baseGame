using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Giris : MonoBehaviour
{
    public Light SpotLight;
    bool isCalled = false;

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(StartLight());
        if (isCalled)
        {
            Enlighten();
            StartCoroutine(ChangeScene());
        }
        
    }

    IEnumerator StartLight()
    {
        yield return new WaitForSeconds(0.3f);
        SpotLight.enabled = true;
        isCalled= true;
    }

  

    void Enlighten()
    {
        if (SpotLight != null && SpotLight.intensity < 1000)
        {
            SpotLight.intensity += Time.deltaTime*500;
        }
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(1);
    }
}
