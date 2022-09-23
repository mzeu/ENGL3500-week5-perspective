using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject10 : MonoBehaviour
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
            this.enabled = false; // you don't want it to flip directions before the door has moved to its max distance
            //once it's traveled max move distance, this function turns on, yeah?
            //at least i assume that's what this.enabled is preventing
        }

        gameObject.transform.Translate(moveDirection * moveSpeed);
    }

    void FlipMoveDirection()
    {
        moveDirection = -moveDirection;
        startingLocation = gameObject.transform.position; //resetting startingLocation so it won't try to calc movement from original position and move too much/little
    }

    float GetDistanceTraveled()
    {
        return Vector3.Distance(gameObject.transform.position, startingLocation);
    }
}
