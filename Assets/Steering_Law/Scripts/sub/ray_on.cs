using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ray_on : MonoBehaviour
{
    private Renderer ThisRenderer;
    private int flag;
    public GameObject Server;
    private receiver script;
    private float timeleft;
    private DateTime presentTime;

    // Start is called before the first frame update
    void Start()
    {
        script = Server.GetComponent<receiver>();
        ThisRenderer = this.gameObject.GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
    }
}
