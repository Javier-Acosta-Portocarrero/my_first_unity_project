using UnityEngine;
using UnityEngine.UI;

public class ThirdExerciseSowPosition : MonoBehaviour
{
    private Vector3 current_position;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        current_position = transform.position;
    }

    void OnGUI()
    {
        // I use this two lines just so I can change the size and color of the text
        GUIStyle text_style = new GUIStyle{fontSize = 20};
        // .normal is the default state of the text, you can also change the color when the mouse is over it or when it is clicked, etc.
        text_style.normal.textColor = Color.green;  
        // The parameters are x, y, width and height, the (0, 0) is on the top left corner
        GUI.Label(new Rect(10, 10, 200, 20), "Sphere position: " + current_position, text_style);
        
    }
}
