using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class result_terop : MonoBehaviour
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
        if(script.task_time_count == 0)
        {
            GetComponent<TextMesh>().text = "practices: " + ((script.task_amount * script.task_time_count) + script.task_count) + " / " + script.task_amount;
        } else
        {
            GetComponent<TextMesh>().text = "times: " + (((script.task_amount * script.task_time_count) + script.task_count) - script.task_amount) + " / " + (script.task_amount * (script.task_time - 1));
            //GetComponent<TextMesh>().text = "task : "+ script.task_time_count +  "\ntimes: " + (script.result_count - 16) + " / 96";
        }

        if (((script.task_amount * script.task_time_count) + script.task_count) >= (script.task_time * script.task_amount))
        {
            GetComponent<TextMesh>().text = "Finish!";
        }
    }
}
