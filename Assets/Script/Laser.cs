using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public GameManager gameManager;

    private int enemyCount;
    private int energyAmount;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        pos.x += 0.05f;

        transform.position = new Vector2(pos.x, pos.y);

        if (pos.x >= 10)
        {
            Destroy(this.gameObject);
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Enemy")
        {
            int enemyCount;

            enemyCount = gameManager.TeachEnemyCount();

            //‚ ‚Á‚½‚Á‚½‚ç“G‚Ì”‚ğ{1‚·‚é
            gameManager.AddEnemyCount();

            energyAmount = gameManager.TeachEnergyAmount();
            gameManager.AddEnergyCount();

            Destroy(gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            int enemyCount;

            enemyCount = gameManager.TeachEnemyCount();

            //—£‚ê‚½‚ç“G‚Ì”‚ğ-1‚·‚é
            gameManager.SubtractEnemyCount();
        }
    }
}
