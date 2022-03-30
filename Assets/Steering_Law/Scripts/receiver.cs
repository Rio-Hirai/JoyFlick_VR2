using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class receiver : MonoBehaviour
{
    public int shiin; //子音の種類
    public string[,] keys = new string[10, 5] { { "あ", "い", "う", "え", "お" }, { "か", "き", "く", "け", "こ" }, { "さ", "し", "す", "せ", "そ" }, { "た", "ち", "つ", "て", "と" }, { "な", "に", "ぬ", "ね", "の" }, { "は", "ひ", "ふ", "へ", "ほ" }, { "ま", "み", "む", "め", "も" }, { "や", "い", "よ", "え", "よ" }, { "ら", "り", "る", "れ", "ろ" }, { "わ", "を", "ん", "ー", "。" }};

    public int key_rock;
    public GameObject keyboard;
    public GameObject controller;
    public Vector3 keyboard_pos;
    public Vector3 keyboard_rot;
    public int input_reset;
    public string input;

    // 実験条件関係
    public int[] display_size = new int[2]; // [0]が横，[1]が縦のピクセルサイズ
    public float distance_d2u = 0.5f; // ユーザとディスプレイ間の距離
    public float[] path_weight = new float[4]; // パスの横幅
    public float[] path_height = new float[4]; // パスの横幅
    public int task_time = 7; // タスクの繰り返し回数
    public int[] path_size_ids = new int[16];
    public struct path_size
    {
        public float p_weight;
        public float p_height;
    }
    public path_size[] p_size_set = new path_size[16];
    private List<int> size_ids = new List<int>();

    // レイキャスト関係
    public GameObject raycast;
    public GameObject raycast_off;
    public GameObject raycast_L;
    public GameObject raycast_L_off;

    // path入退関係
    public int path_swi = 1;
    public int pash_in = 0;
    public int start_in = 0;
    public int goal_in = 0;

    // task関係
    public int task_amount;
    public int task_time_count = 0;
    public int task_count = 0;
    public float tasktime = 0.0f;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 stickR = OVRInput.Get(OVRInput.RawAxis2D.RThumbstick);
        float stickrot = (Mathf.Atan2(stickR.y, stickR.x) * Mathf.Rad2Deg + 180.0f);

        Debug.Log("stickrot = " + stickrot);

        if (OVRInput.Get(OVRInput.RawButton.RThumbstick))
        {
            shiin = 10;
        }
        else
        {
            if (stickrot == 180)
            {
                shiin = 5;
            }
            else if (stickrot < 22.5f)
            {
                shiin = 4;
            }
            else if (stickrot < 67.5)
            {
                shiin = 7;
            }
            else if (stickrot < 112.5)
            {
                shiin = 8;
            }
            else if (stickrot < 157.5)
            {
                shiin = 9;
            }
            else if (stickrot < 202.5)
            {
                shiin = 6;
            }
            else if (stickrot < 247.5)
            {
                shiin = 3;
            }
            else if (stickrot < 292.5)
            {
                shiin = 2;
            }
            else if (stickrot < 337.5)
            {
                shiin = 1;
            }
            else if (stickrot < 360)
            {
                shiin = 4;
            }
        }

        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
        {
            key_rock = 1;
        }
        else if (OVRInput.GetUp(OVRInput.RawButton.RIndexTrigger))
        {
            key_rock = 0;
        }

        if (key_rock == 0)
        {
            keyboard.transform.position = controller.transform.position;
            keyboard.transform.rotation = controller.transform.rotation;
        }

        if (OVRInput.GetDown(OVRInput.RawButton.B))
        {
            input = input.Substring(0, input.Length - 1);
        }

        //Debug.Log(stickR + ", " + (Mathf.Atan2(stickR.y, stickR.x) * Mathf.Rad2Deg + 180) + ", " + shiin);
    }
}