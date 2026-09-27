using UnityEngine;

public class FirstExerciseRandomChangingColor : MonoBehaviour
{
    public int current_frame = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Current frame: " + current_frame);
        ++current_frame;
        if (current_frame == 120) 
        {
            Vector3 random_color = new Vector3(Random.value, Random.value, Random.value);
            GetComponent<Renderer>().material.color = new Color(random_color.x, random_color.y, random_color.z);
            current_frame = 0;
        }
    }
}
