using UnityEngine;
using System.Collections;

public class GolfSwing : MonoBehaviour {
    public void IncreaseForce(Rigidbody rb, float force)
    {
        print("Increasing force");
            rb.AddForce(transform.forward*force);
    }
}
