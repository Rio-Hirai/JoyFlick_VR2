using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
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
        script.start_in = 1;
        script.pash_in = 0;
        script.goal_in = 0;
        //Debug.Log("start_in");
    }

    private void OnTriggerExit(Collider collider)
    {
        script.start_in = 2;
        //script.goal_in = 0;
        //Debug.Log("start_out");
    }

    //// ÚG
    //// ÚG‚µ‚Ä‚¢‚éŠÔ
    //private void OnTriggerStay(Collider collider)
    //{

    //}

}
