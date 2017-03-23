using UnityEngine;
using System.Collections;

public class ClubInherit : GolfSwing {
    public int maxSwingPower;
    public int curSwingPower;

    float timer;
    public float incTime;

    public bool increasingForce;

    public Rigidbody golfy;
    public enum State
    {
        aiming,
        swinging,
        striking
    }
    GolfSwing golfSwing;
    void Start()
    {
         golfSwing = new GolfSwing();
    }

    public void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            timer = Time.time;
            if (timer % 1 == 0)
            {
                if (curSwingPower < maxSwingPower)
                {
                    curSwingPower++;
                }
            } 
        }
        if (Input.GetButtonUp("Fire1"))
        {
            golfSwing.IncreaseForce(golfy,curSwingPower);
            timer = 0;
        }
    }
}
