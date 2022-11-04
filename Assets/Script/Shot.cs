using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject Bullet;
    private int shotCount;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        shotCount++;

        //カウントが200になったら攻撃
        if (shotCount >= 200)
        {
            //Debug.Log("shotCount " + shotCount);
            //スペースキーが押されていない時
            if (!Input.GetKey(KeyCode.Space))
            {
                Instantiate(Bullet, transform.position, Quaternion.identity);
                shotCount = 0;
            }
        }
    }
}
