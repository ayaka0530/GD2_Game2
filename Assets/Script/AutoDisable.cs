using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDisable : MonoBehaviour
{
    public float disableTime = 10;
    public float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        if (time <= 0) 
        {
            gameObject.SetActive(false);
        }
    }

    //—LŒø‚É‚È‚Á‚½Žž‚ÉŒÄ‚Î‚ê‚é‚â‚Â
    private void OnEnable()
    {
        time = disableTime;
    }
}
