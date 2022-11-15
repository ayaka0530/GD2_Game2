using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager gameManager;

    private float speed = 0.2f;
    private int playerHp;
    private int energyAmount;
    private int power = 1;
    private int playerLv;
    private GameObject[] shots;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        shots = GameObject.FindGameObjectsWithTag("Shot");

        playerHp = 3;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;

        if (Input.GetKey("left") || (Input.GetKey(KeyCode.A)))
        {
            position.x -= speed;
        }
        else if (Input.GetKey("right") || (Input.GetKey(KeyCode.D)))
        {
            position.x += speed;
        }
        else if (Input.GetKey("up") || (Input.GetKey(KeyCode.W)))
        {
            position.y += speed;
        }
        else if (Input.GetKey("down") || (Input.GetKey(KeyCode.S)))
        {
            position.y -= speed;
        }

        transform.position = position;

        //取得したエナジー毎にレベルアップ
        //エナジーの数を取得
        energyAmount = gameManager.TeachEnergyAmount();

        //if (energyAmount <= 0)
        //{
        //    power = power + 0;
        //}
        //else
        if (energyAmount >= 100)
        {
            power = 3;
        }
        //else if (energyAmount >= 500)
        //{
        //    power = 6;
        //}

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            for(int i = 0; i <= 1; i++)
            {
                shots[i].GetComponent<Shot>().mode = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            for (int i = 0; i <= 1; i++)
            {
                shots[i].GetComponent<Shot>().mode = 1;
            }
        }

        if (playerHp <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.GetComponent<Enemy>().EnemyDamage();
        }
    }

    public int TeachPlayerPower()
    {
        return power;
    }

    public void PlayerDamage()
    {
        playerHp = playerHp - 1;
    }
}
