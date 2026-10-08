using UnityEngine;

public class SecondExerciseVector3Manipulation : MonoBehaviour
{
    public Vector3 first_vector = new Vector3(0.0f, 0.0f, 0.0f);
    public Vector3 second_vector = new Vector3(0.0f, 0.0f, 0.0f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CalculateVector3Properties();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CalculateVector3Properties() 
    {
        Debug.Log("Exercise 2");
        Debug.Log("First vector " + first_vector + " magnitude: " + first_vector.magnitude);
        Debug.Log("Second vector " + second_vector + " magnitude: " + second_vector.magnitude);
        Debug.Log("Angle between both vectors  : " + Vector3.Angle(first_vector, second_vector) + " degrees");
        Debug.Log("Distance between both vectors: " + Vector3.Distance(first_vector, second_vector));
        Debug.Log("The vector with the most height is the " + (first_vector.y > second_vector.y ? "first ": "second ") + "one");
    }
}
