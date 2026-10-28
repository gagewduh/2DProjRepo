using Mono.Cecil.Cil;
using UnityEngine;

public class ConditionalStatements1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(true)
        {
            //always run
        }
        if(false)
        {
            //never run
        }
        if(true && true)
        {
            //code will run

        }
        if(true && false)
        { 
        //one is false so it wont run, like having enough of one stat but not of the other
        }
        if (true || false)
        {
            //one is true so it runs
        }
        if(true && true || false && false || true && false || true && true)
        {
            //this code runs
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
