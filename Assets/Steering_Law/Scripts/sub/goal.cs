using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class goal : MonoBehaviour
{
    public string input;
    public GameObject Server;
    private receiver script;

    void Start()
    {
        script = Server.GetComponent<receiver>();
    }

    private void Update()
    {
    }

    private void OnTriggerEnter(Collider collider)
    {
        script.goal_in = 1;
        script.start_in = 0;
        //Debug.Log("goal_in");
    }

    private void OnTriggerExit(Collider collider)
    {
        script.goal_in = 2;
        //script.pash_in = 0;
        script.start_in = 0;
        //Debug.Log("goal_out");
    }

    //// ÚG
    //// ÚG‚µ‚Ä‚¢‚éŠÔ
    //private void OnTriggerStay(Collider collider)
    //{

    //}

}