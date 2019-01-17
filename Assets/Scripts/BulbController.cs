using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulbController : MonoBehaviour
{

    //Bulb Controller Start

    public SwitchController theSwitch;

    private Animator LightBulb;

    private bool lightOn;

    private bool lightOff;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void Awake()
    {
        public void turnOn()
        {
            switchOff = false;
            LightBulb.SetBool("LightOff", lightOff);
        }

        public void turnOff()
        {
            switchOff = true;
            LightBulb.SetBool("LightOff", lightOff);
        }
    }
}
