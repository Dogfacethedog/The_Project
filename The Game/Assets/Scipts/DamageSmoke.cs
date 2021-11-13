using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSmoke : MonoBehaviour
{
    [SerializeField] ParticleSystem Smoke = null;

    public PlayerMovement movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Damage Detector")
        {
            Smoke.Play();
            movement.enabled = false;
        }
    }
}
