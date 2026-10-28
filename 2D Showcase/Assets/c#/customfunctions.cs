using UnityEngine;

public class CustomFunctions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LevelUp();
    }

    // Update is called once per frame
    void Update()
    {
        LevelUp();
    }
    //I can create my own custom function right here
    public int xp = 10000;
    public int level = 1;
    void LevelUp()
    {
        //when we level up, we increase our player level if xp is high enough, then reduce xp
        //two variables we really care about: XP and level (maybe: xp cap, stats, etc)
        if (xp >= 100)
        {
            //increase level, reset xp
            level = level + 1;
            //level++;
            //level+=1;
            xp = xp - 100;
            Debug.Log("DING! You leveled up! Grats");
        }
    }
}
