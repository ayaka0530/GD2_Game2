using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Start()
    {

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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.GetComponent<Enemy>().Damage();
        }
    }
}
