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

        //�J�E���g��200�ɂȂ�����U��
        if (shotCount >= 200)
        {
            //Debug.Log("shotCount " + shotCount);
            //�X�y�[�X�L�[��������Ă��Ȃ���
            if (!Input.GetKey(KeyCode.Space))
            {
                Instantiate(Bullet, transform.position, Quaternion.identity);
                shotCount = 0;
            }
        }
    }
}
