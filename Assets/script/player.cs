using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager gameManager;

    private float speed = 0.05f;
    private int energyAmount;
    private int power;
    private int playerLv;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
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

        if (energyAmount <= 0)
        {
            power = 0;
            power = TeachPlayerPower();
        }
        else if (energyAmount <= 100)
        {
            power = 3;
            power = TeachPlayerPower();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.GetComponent<Enemy>().Damage();
        }
    }

    public int TeachPlayerPower()
    {
        return power;
    }
}
