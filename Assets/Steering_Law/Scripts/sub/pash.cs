using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class pash : MonoBehaviour
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
        if (script.pash_in == 1)
        {
            script.tasktime += Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (script.start_in != 0)
        {
            script.pash_in = 1;
            //Debug.Log("goal_in");
        }
    }

    private void OnTriggerStay(Collider collider)
    {
        //Vector3 hitPos = collider.ClosestPointOnBounds(this.transform.position);
        //Debug.Log("pos = " + hitPos);
        script.pash_in = 1;
    }

    private void OnTriggerExit(Collider collider)
    {
        script.pash_in = 2;
        //Debug.Log("goal_out");
    }

    //// ê⁄êGéû
    //// ê⁄êGÇµÇƒÇ¢ÇÈä‘
    //private void OnTriggerStay(Collider collider)
    //{

    //}

}
