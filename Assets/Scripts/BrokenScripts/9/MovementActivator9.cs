using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementActivator9 : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;
    [SerializeField] GameObject otherObjectToActivate;

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
        objectToActivate.GetComponent<MoveObject9>().enabled = true;
        otherObjectToActivate.GetComponent<MoveObject9>().enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        objectToActivate.GetComponent<MoveObject9>().enabled = true;
        otherObjectToActivate.GetComponent<MoveObject9>().enabled = true;
    }
}
