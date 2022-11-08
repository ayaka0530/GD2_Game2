using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int playerLv;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int TeachLvCount()
    {
        return playerLv;
    }

    public void AddHatCount()
    {

        playerLv = playerLv + 1;
        //Debug.Log("HatCount:" + hatCount);

    }
}
