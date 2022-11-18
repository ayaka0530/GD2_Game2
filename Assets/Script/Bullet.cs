using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float pi = 3.1415f;
    public GameManager gameManager;
    public float angle = 0;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 0.5f;

        float angleRad = angle * (pi/180);

        Vector2 direction = new Vector2(Mathf.Cos(angleRad), Mathf.Sin(angleRad));

        direction *= speed;

        //”ò‚ñ‚Å‚¢‚­•ûŒü
        Vector2 pos = transform.position;

        pos.x += direction.x;
        pos.y += direction.y;

        transform.position = new Vector2(pos.x, pos.y);

        //‰æ–ÊŠOo‚½‚ç–³‚­‚È‚é
        if (pos.x >= 9)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.GetComponent<Enemy>().EnemyDamage();
            gameManager.AddEnergyCount();
            gameManager.AddScoreCount();
        }
    }
}
