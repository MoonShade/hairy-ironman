using UnityEngine;
using System.Collections;

public class Globals
{

    private static int Lifes = 3;
    private static int Coins = 0;

    public static void ReduceLife()
    {
        Lifes -= 1;
        if (Lifes <= 0)
        {
            //game over
            Lifes = 3;
            Application.LoadLevel("GameOver");
        }
        else
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }


    public static int LifeCount()
    {
        return Lifes;
    }

    public static void AddCoin()
    {
        Debug.Log(Coins);
        Coins += 1;
    }

    public static int GetCoinCount()
    {
        return Coins;
    }

}
