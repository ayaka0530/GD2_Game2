using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charge : MonoBehaviour
{
    public GameObject laser;
    private int ChargeCount;

    public Sprite normalShotImage;//通常攻撃の画像
    public Sprite chargingShotImage;//チャージ攻撃の画像


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
            gameObject.GetComponent<SpriteRenderer>().sprite = chargingShotImage;
            //カウントが10になったら攻撃
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
