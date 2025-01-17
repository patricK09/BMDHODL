﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleB : MonoBehaviour
{
    private int enemyDistance = 0;
    private int enemyCount = 10;

    private string[] enemies = new string[5];
    private int weaponId = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            //EnemySearch();
            //EnemyDestruction();
            //EnemyScan();
            //EnemyRoster();
            WeaponSearch();
        }
    }

    void EnemySearch()
    {
        for (int i = 0; i < 5; i++)
        {
            enemyDistance = Random.Range(1, 10);

            if (enemyDistance >= 8)
            {
                print("An enemy is far away!");
            }
            if (enemyDistance >= 4 && enemyDistance <= 7)
            {
                print("An enemy is at medium range!");
            }
            if (enemyDistance < 4)
            {
                print("An enemy is very close by!");
            }
        }
    }

    void EnemyDestruction()
    {
        while (enemyCount > 0)
        {
            print("There is an enemy! Let's destroy it!");
            enemyCount--;
        }
    }

    void EnemyScan()
    {
        bool isAlive = false;

        do
        {
            print("Scanning for enemies!");
        } while (isAlive == true);
    }

    void EnemyRoster()
    {
        enemies[0] = "Orc";
        enemies[1] = "Dragon";
        enemies[2] = "Orc";
        enemies[3] = "Dragon";
        enemies[4] = "Dragon";

        foreach (string enemy in enemies)
        {
            print(enemy);
        }
    }

    void WeaponSearch()
    {
        weaponId = Random.Range(0, 8);

        switch (weaponId)
        {
            case 1:
                print("You found a sword!");
                break;
            case 2:
                print("You found an axe!");
                break;
            case 3:
                print("You found a dagger!");
                break;
            case 4:
                print("You found a bow!");
                break;
            default:
                print("You didn't find anything!");
                break;
        }
    }
}