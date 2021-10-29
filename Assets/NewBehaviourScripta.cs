using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScripta : MonoBehaviour
{
    public GameObject targetObject;

    void OnTriggerEnter(Collider other)
    {
        targetObject.SetActive(false);
    }

    void OnTriggerExit(Collider other)
    {
        targetObject.SetActive(true);
    }
}