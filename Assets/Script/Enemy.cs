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
    }

    // Update is called once per frame
    void Update()
    {
        //”ò‚ñ‚Å‚¢‚­•ûŒü
        Vector2 pos = transform.position;

        pos.x -= 0.01f;

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
    public void Damage()
    {
        playerPower = player.TeachPlayerPower();
        enemyHp = enemyHp - playerPower;
        Debug.Log("enemyHp" + enemyHp);
    }

}
