using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject8 : MonoBehaviour
{
    [SerializeField] float moveSpeed; //need moveSpeed serialized b/c there's no preset speed in code. without speed, no movement
    [SerializeField] Vector3 moveDirection;

    float totalMoveDistance; //type of var needs to be declared
    Vector3 startingLocation;   


    void Start()
    {
        totalMoveDistance = 10f;
        startingLocation = gameObject.transform.position;
    }

    void Update()
    {
        float distanceTraveled = GetDistanceTraveled();

        if (distanceTraveled > totalMoveDistance)
        {
            FlipMoveDirection();
            this.enabled = false;
        }

        gameObject.transform.Translate(moveDirection * moveSpeed);
    }

    void FlipMoveDirection()
    {
        moveDirection = -moveDirection;
        startingLocation = gameObject.transform.position;
    }

    float GetDistanceTraveled()
    {
        return Vector3.Distance(gameObject.transform.position, startingLocation);
    }
}
