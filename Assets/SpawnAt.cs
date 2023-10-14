using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAt : MonoBehaviour
{
    public GameObject text;
    public GameObject positiona;
    public GameObject gameObject;
    public CharacterController myCharacter;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            text.SetActive(true);
            myCharacter.enabled = false;
            gameObject.transform.position = positiona.transform.position;
            myCharacter.enabled = true;
        }

    }
}
