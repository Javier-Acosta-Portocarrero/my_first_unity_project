using UnityEngine;

public class FourthExerciseCalculaDistanceBetweenGameObjects : MonoBehaviour
{
    public string cubeTag = "random_color_cube";
    public string cylinderTag = "suspicious_cylinder";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       CalculateDistanceToGameObjects();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CalculateDistanceToGameObjects() 
    {
        Vector3 cubePosition = GameObject.FindWithTag(cubeTag).transform.position;
        Vector3 cylinderPosition = GameObject.FindWithTag(cylinderTag).transform.position;

        Debug.Log("Exercise 4");
        Debug.Log("Distance to the cube: " + Vector3.Distance(transform.position, cubePosition));
        Debug.Log("Distance to the cylinder: " + Vector3.Distance(transform.position, cylinderPosition));
    }
}
