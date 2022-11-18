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
        //飛んでいく方向
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

    //敵がプレイヤーにあたったらプレイヤーにダメージ
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<Player>().PlayerDamage();
        }
    }

    //敵に入るダメージの計算
    public void EnemyDamage()
    {
        playerPower = player.TeachPlayerPower();
        enemyHp = enemyHp - playerPower;
        //Debug.Log("enemyHp" + enemyHp);
    }

}
