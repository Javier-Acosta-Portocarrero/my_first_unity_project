using UnityEngine;

public class FourthExerciseCalculaDistanceBetweenGameObjects : MonoBehaviour
{
    public string cube_tag = "random_color_cube";
    public string cylinder_tag = "suspicious_cylinder";
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
        Vector3 cube_position = GameObject.FindWithTag(cube_tag).transform.position;
        Vector3 cylinder_position = GameObject.FindWithTag(cylinder_tag).transform.position;

        Debug.Log("Exercise 4");
        Debug.Log("Distance to the cube: " + Vector3.Distance(transform.position, cube_position));
        Debug.Log("Distance to the cylinder: " + Vector3.Distance(transform.position, cylinder_position));
    }
}
