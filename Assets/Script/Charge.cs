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
        //�X�y�[�X�L�[��������Ă��鎞
        if (Input.GetKey(KeyCode.Space))
        {
            ChargeCount++;

            //�J�E���g��10�ɂȂ�����U��
            if (ChargeCount >= 10)
            {
                Instantiate(laser, transform.position, Quaternion.identity);
                ChargeCount = 0;
            }
        }
    }
}
