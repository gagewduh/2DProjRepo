using UnityEngine;

public class PointsIfAssignment : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int swag_points = 15;
            if (swag_points >= 25)
        {
            Debug.Log("Swag-a-licious");
        }
        if (swag_points < 25)
        {
            Debug.Log("not very swag of you");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
