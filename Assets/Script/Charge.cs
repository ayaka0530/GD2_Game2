using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charge : MonoBehaviour
{
    public GameObject laser;
    private int ChargeCount;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //スペースキーが押されている時
        if (Input.GetKey(KeyCode.Space))
        {
            ChargeCount++;

            //カウントが10になったら攻撃
            if (ChargeCount >= 10)
            {
                Instantiate(laser, transform.position, Quaternion.identity);
                ChargeCount = 0;
            }
        }
    }
}
