using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0.5f, 0, 0);

        //if (transform.position.y > 5)
        //{
        //    Destroy(gameObject);
        //}

        Vector2 pos = transform.position;

        pos.x += 0.05f;

        transform.position = new Vector2(pos.x, pos.y);

        if (pos.x >= 20)
        {
            Destroy(this.gameObject);
        }
    }
}
