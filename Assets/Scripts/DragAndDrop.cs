
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour
{
    public Color mouseOverColor = Color.blue;
    public Color originalColor = Color.yellow;
    public bool dragging = false;
    public float distance;

    float Timer = 0.0f;
    bool StartTimer = true;

    public void OnMouseEnter()
    {
       // GetComponent<Renderer>().material.color = mouseOverColor;
    }

    public void OnMouseExit()
    {
       // GetComponent<Renderer>().material.color = originalColor;
    }

    public void OnMouseDown()
    {
        Debug.Log("dds");
        distance = Vector3.Distance(transform.position, Camera.main.transform.position);
        dragging = true;
    }

    public void OnMouseUp()
    {
        dragging = false;
    }

    void Update()
    {
        if (dragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            transform.position = rayPoint;
        }

        if (StartTimer == true)
        {
            Timer += Time.deltaTime;
            Debug.Log(Timer);
        }
        
        
    }

    void Start()
    {
        
    }

    
}
