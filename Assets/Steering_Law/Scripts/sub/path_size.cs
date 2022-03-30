using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class path_size : MonoBehaviour
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
        //this.transform.localScale = new Vector3(script.path_weight[script.path_weight_ids[script.task_count] % 4], script.path_height[script.path_height_ids[script.task_count] % 4], 0.002f);

        if (script.path_swi == 1)
        {
            //this.transform.localScale = new Vector3(script.path_weight[script.path_weight_ids[script.task_count] % 4], script.path_height[script.path_height_ids[script.task_count] % 4], 0.002f);
            this.transform.localScale = new Vector3(script.p_size_set[script.path_size_ids[script.task_count % 16]].p_weight / script.display_size[0], script.p_size_set[script.path_size_ids[script.task_count % 16]].p_height / script.display_size[1], 0.002f);
            script.path_swi = -1;

            script.pash_in = 0;
            script.goal_in = 0;
            script.start_in = 0;
        } else if(script.path_swi == -1)
        {
            script.path_swi = 0;
        }

    }
}
