using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject Bullet;
    private int shotCount;
    public float angle = 60;
    public int mode = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        shotCount++;

        //�J�E���g��200�ɂȂ�����U��
        if (shotCount >= 50)
        {
            //Debug.Log("shotCount " + shotCount);
            //�X�y�[�X�L�[��������Ă��Ȃ���
            if (!Input.GetKey(KeyCode.Space))
            {
                if (mode == 0)
                {
                    SingleShot();
                }
                else if(mode ==1)
                {
                    ThreeWayShot();
                }

                shotCount = 0;

            }
        }
    }

    private void ThreeWayShot()
    {
        for (int i = 0; i <= 2; i++)
        {
            GameObject bulletObject = Instantiate(Bullet, transform.position, Quaternion.identity);
            Bullet bullet = bulletObject.GetComponent<Bullet>();
            bullet.angle = 30 * i - 30;
        }
    }

    private void SingleShot()
    {
        GameObject bulletObject = Instantiate(Bullet, transform.position, Quaternion.identity);
        Bullet bullet = bulletObject.GetComponent<Bullet>();
        bullet.angle = 0;
    }
}
