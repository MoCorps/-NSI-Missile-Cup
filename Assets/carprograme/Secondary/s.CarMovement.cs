using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class sCarMovement : MonoBehaviour
{

    [SerializeField] WheelCollider FrontRight;
	[SerializeField] WheelCollider FrontLeft;
	[SerializeField] WheelCollider BackRight;
	[SerializeField] WheelCollider BackLeft;

	[SerializeField] Transform FrontRightTransform;
	[SerializeField] Transform FrontLeftTransform;
	[SerializeField] Transform BackRightTransform;
	[SerializeField] Transform BackLeftTransform;

	public float acceleration = 2000f;
	public float maxTurnAngle = 45f;

	public float speed = 1.1f;

	public float currentAcceleration = 0f;
	public float currentBreakForce = 5000000f;
	public float currentTurnAngle = 0f;



    private void FixedUpdate()
	{

		//forward backwards and break
		if (Input.GetKey(KeyCode.I) == true || Input.GetKey(KeyCode.K) == true)
		{
            currentBreakForce = 0f;
        }
		else
		{
            currentBreakForce = 5000000f;
            currentAcceleration = 0f;
        }
		

		if (Input.GetKey(KeyCode.I) == true)
		{
            currentAcceleration = acceleration * speed;
        }
			
		

		if (Input.GetKey(KeyCode.K) == true)
		{
            currentAcceleration = acceleration * speed * -1;
        }
		


        //acceleration (all wheels) setup
        FrontRight.motorTorque = currentAcceleration;
		FrontLeft.motorTorque = currentAcceleration;
		BackRight.motorTorque = currentAcceleration;
		BackLeft.motorTorque = currentAcceleration;

		//break setup
		FrontRight.brakeTorque = currentBreakForce;
		FrontLeft.brakeTorque = currentBreakForce;
		BackRight.brakeTorque = currentBreakForce;
		BackLeft.brakeTorque = currentBreakForce;

		//steering
		currentTurnAngle = maxTurnAngle * Input.GetAxis("HorizontalTwo");
		FrontLeft.steerAngle = currentTurnAngle;
		FrontRight.steerAngle = currentTurnAngle;

		//wheel mesh
		UpdateWheel(FrontRight, FrontRightTransform);
		UpdateWheel(FrontLeft, FrontLeftTransform);
		UpdateWheel(BackRight, BackRightTransform);
		UpdateWheel(BackLeft, BackLeftTransform);

	}

	void UpdateWheel(WheelCollider col, Transform trans) //fonction to update wheel meshes
	{

		//get wheel state
		Vector3 position;
		Quaternion rotation;
		col.GetWorldPose (out position, out rotation);

		//make wheels move
		trans.position = position;
		trans.rotation = rotation;
	}
}