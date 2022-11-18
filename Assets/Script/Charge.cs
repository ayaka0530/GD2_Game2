using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charge : MonoBehaviour
{
    public GameObject laser;
    private int ChargeCount;

    public Sprite normalShotImage;//�ʏ�U���̉摜
    public Sprite chargingShotImage;//�`���[�W�U���̉摜


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
            gameObject.GetComponent<SpriteRenderer>().sprite = chargingShotImage;
            //�J�E���g��10�ɂȂ�����U��
            if (ChargeCount >= 5)
            {
                Instantiate(laser, transform.position, Quaternion.identity);
                ChargeCount = 0;
            }
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = normalShotImage;
        }
    }
}
