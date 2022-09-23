using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementActivator10 : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;
    [SerializeField] GameObject otherObjectToActivate; //needs to be serialized so we can attach both doors to this script on the activator

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        objectToActivate.GetComponent<MoveObject10>().enabled = true; // refers to wrong script (one from previous scene, which isnt in the folder, so unity is liek ?)
        otherObjectToActivate.GetComponent<MoveObject10>().enabled = true; // you dont want to know how long i was stuck on this
    }

    private void OnTriggerExit(Collider other)
    {
        objectToActivate.GetComponent<MoveObject10>().enabled = true; // --
        otherObjectToActivate.GetComponent<MoveObject10>().enabled = true; // --
    }
}
