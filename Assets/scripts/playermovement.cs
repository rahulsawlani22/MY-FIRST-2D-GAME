using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
  public Rigidbody rb;
  public float ForwardForce=2000f;
  public float sidewaysforce=200f;

    // Update is called once per frame
    void FixedUpdate() //fixed for dealing physics
    {
      rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
      if(Input.GetKey("d"))
      {
        rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
      }
      if(Input.GetKey("a"))
      {
        rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
      }
      if(rb.position.y < -1f)
      {
        FindObjectOfType<gamemanager>().EndGame();
      }
    }
}
