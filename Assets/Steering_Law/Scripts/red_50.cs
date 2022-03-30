using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class red_50 : MonoBehaviour
{
    public GameObject Server;
    public int num;
    private receiver script;
    // Start is called before the first frame update
    void Start()
    {
        script = Server.GetComponent<receiver>();
    }

    // Update is called once per frame
    void Update()
    {
        if (num == script.shiin)
        {
            GetComponent<TextMesh>().color = new Color(1, 0, 0, 1);
        }
        else
        {
            GetComponent<TextMesh>().color = new Color(1, 1, 1, 1);
        }
    }
}
