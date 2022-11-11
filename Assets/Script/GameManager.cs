using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int enemyCount;
    private int energyCount;
    //public Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        //Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddEnemyCount()
    {
        enemyCount = enemyCount + 1;
        Debug.Log("enemyCount:" + enemyCount);
        //textComponent.text = "enemyCount : " + enemyCount;
    }

    //å∏ÇÁÇ∑ä÷êî
    public void SubtractEnemyCount()
    {
        enemyCount = enemyCount - 1;
        Debug.Log("enemyCount:" + enemyCount);
        //textComponent.text = "enemyCount : " + enemyCount;
    }

    public int TeachEnemyCount()
    {

        return enemyCount;
    }

    public void AddEnergyCount()
    {
        energyCount = energyCount + 1;
        Debug.Log("energyCount:" + energyCount);
        //textComponent.text = "HatCount : " + energyCount;
    }

    public int TeachEnergyAmount()
    {

        return energyCount;
    }
}
