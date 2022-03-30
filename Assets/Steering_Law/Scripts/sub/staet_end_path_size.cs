using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staet_end_path_size : MonoBehaviour
{
    public GameObject Server;
    private receiver script;

    void Start()
    {
        script = Server.GetComponent<receiver>();
    }

    // Update is called once per frame
    void Update()
    {
        if (script.path_swi == -1)
        {
            this.transform.localScale = new Vector3(0.5f, script.p_size_set[script.path_size_ids[script.task_count % 16]].p_height / script.display_size[1], 0.0002f);
        }
    }
}
