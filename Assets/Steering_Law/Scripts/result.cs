using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class result : MonoBehaviour
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
        GetComponent<TextMesh>().text = "input: " + script.input;
    }
}
