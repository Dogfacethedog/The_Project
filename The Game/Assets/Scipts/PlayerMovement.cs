
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float MotorForce, SteerForce, BrakeForce;
	public WheelCollider FR_collider, FL_collider, RR_collider, RL_collider;

     void Update()
    {
        float v = Input.GetAxis("Vertical") * MotorForce;
        float h = Input.GetAxis("Horizontal") * SteerForce;

        RR_collider.motorTorque = v;
        RL_collider.motorTorque = v;

        FR_collider.steerAngle = h;
        FL_collider.steerAngle = h;

        if (Input.GetKey("s"))
        {
            RR_collider.brakeTorque = BrakeForce;
            RL_collider.brakeTorque = BrakeForce;
            FL_collider.brakeTorque = BrakeForce;
            FR_collider.brakeTorque = BrakeForce;
        }

        if (Input.GetKeyUp("s")) 
        {
            RR_collider.brakeTorque = 0;
            RL_collider.brakeTorque = 0;
            FL_collider.brakeTorque = 0;
            FR_collider.brakeTorque = 0;
        }

        if(Input.GetAxis("Vertical") == 0) 
        {
            RR_collider.brakeTorque = BrakeForce;
            RL_collider.brakeTorque = BrakeForce;
            FL_collider.brakeTorque = BrakeForce;
            FR_collider.brakeTorque = BrakeForce;    
        }
        else 
        {
            RR_collider.brakeTorque = 0;
            RL_collider.brakeTorque = 0;
            FL_collider.brakeTorque = 0;
            FR_collider.brakeTorque = 0;
        }
    }

}