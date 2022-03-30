using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input_reset : MonoBehaviour
{
    public GameObject Server;
    private receiver script;
    // Start is called before the first frame update
    void Start()
    {
        script = Server.GetComponent<receiver>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider collider)
    {
        if (script.input_reset == 1)
        {
            script.input_reset = 0;
        }
    }
}
