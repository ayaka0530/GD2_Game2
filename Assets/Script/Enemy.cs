using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int enemyHp;
    private int playerPower;
    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        enemyHp = 3;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        //���ł�������
        Vector2 pos = transform.position;

        pos.x -= 0.05f;

        transform.position = new Vector2(pos.x, pos.y);

        if (enemyHp <= 0)
        {
            Destroy(this.gameObject);
        }
        else if (pos.x <= -10)
        {
            Destroy(this.gameObject);
        }

    }

    //�G���v���C���[�ɂ���������v���C���[�Ƀ_���[�W
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<Player>().PlayerDamage();
        }
    }

    //�G�ɓ���_���[�W�̌v�Z
    public void EnemyDamage()
    {
        playerPower = player.TeachPlayerPower();
        enemyHp = enemyHp - playerPower;
        //Debug.Log("enemyHp" + enemyHp);
    }

}
