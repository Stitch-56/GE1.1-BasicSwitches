using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulbController : MonoBehaviour
{
    private Animator LightBulb;

    public bool LightOff;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void turnOn()
    {
        LightBulb.SetBool("On", true);
        LightOff = true;
    }

    public void turnOff()
    {
        LightBulb.SetBool("Off", false);
        LightOff = false;
    }
}
