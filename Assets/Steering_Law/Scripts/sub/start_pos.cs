using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_pos : MonoBehaviour
{
    public GameObject Server;
    public GameObject headpos;
    private receiver script;

    // Start is called before the first frame update
    void Start()
    {
        script = Server.GetComponent<receiver>();
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.A) || OVRInput.GetDown(OVRInput.RawButton.X))
        {

            Transform myTransform1 = this.transform;
            Transform myTransform2 = headpos.transform;

            Vector3 pos1 = myTransform1.position;
            Vector3 pos2 = myTransform2.position;
            pos1.x = pos2.x;
            pos1.y = pos2.y;
            pos1.z = script.distance_d2u;

            myTransform1.position = pos1;
        }
    }
}
