using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiRollScript : MonoBehaviour
{

    public WheelCollider BackLeftCollider;
    public WheelCollider BackRightCollider;
    public float AntiRoll = 5000.0f;

    private Rigidbody rigidBody;

    void Start()
    {

        rigidBody = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {

        WheelHit hit;
        float travelL = 1.0f;
        float travelR = 1.0f;

        bool groundedL = BackLeftCollider.GetGroundHit(out hit);
        if (groundedL)
        {

            travelL = (-BackLeftCollider.transform.InverseTransformPoint(hit.point).y - BackLeftCollider.radius) / BackLeftCollider.suspensionDistance;

        }

        bool groundedR = BackRightCollider.GetGroundHit(out hit);
        if (groundedL)
        {

            travelR = (-BackRightCollider.transform.InverseTransformPoint(hit.point).y - BackRightCollider.radius) / BackRightCollider.suspensionDistance;

        }

        float antiRollForce = (travelL - travelR) * AntiRoll;

        if (groundedL)
            rigidBody.AddForceAtPosition(BackLeftCollider.transform.up * -antiRollForce, BackLeftCollider.transform.position);

        if (groundedR)
            rigidBody.AddForceAtPosition(BackRightCollider.transform.up * antiRollForce, BackRightCollider.transform.position);

    }

}