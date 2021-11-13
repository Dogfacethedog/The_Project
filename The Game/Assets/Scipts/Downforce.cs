using UnityEngine;

public class Downforce : MonoBehaviour
{
    public float downforce = 200f;
    public Rigidbody rb;
   
    void FixedUpdate()
    {
        rb.AddForce(0, -downforce, 0);
    }
}
