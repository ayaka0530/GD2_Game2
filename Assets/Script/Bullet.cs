using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //���ł�������
        Vector2 pos = transform.position;

        pos.x += 0.05f;

        transform.position = new Vector2(pos.x, pos.y);

        //��ʊO�o���疳���Ȃ�
        if (pos.x >= 9)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.GetComponent<Enemy>().Damage();
            gameManager.AddEnergyCount();
        }
    }
}
