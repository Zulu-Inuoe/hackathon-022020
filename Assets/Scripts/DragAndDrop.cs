
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;


class DragAndDrop : MonoBehaviour
{

    public enum ItemType { Plastic, eWaste, Landfill, Paper, none };

    public GameObject Image;
    public Sprite PlasticSprite;
    public Sprite EWasteSprite;
    public Sprite LandfillSprite;
    public Sprite PaperSprite;

    public Color mouseOverColor = Color.blue;
    public Color originalColor = Color.yellow;
    public bool dragging = false;
    public float distance;

    float Timer = 0.0f;
    bool StartTimer = true;

    public ItemType myItem;

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
        int randomNum = Random.Range(0, 3);
        
        switch (randomNum)
        {
            case 0:
                Debug.Log("0");
                myItem = ItemType.Plastic;
                this.GetComponent<SpriteRenderer>().sprite = PlasticSprite;

                break;

            case 1:
                Debug.Log("1");
                myItem = ItemType.Paper;
                this.GetComponent<SpriteRenderer>().sprite = EWasteSprite;
                break;

            case 2:
                Debug.Log("2");
                myItem = ItemType.eWaste;
                 this.GetComponent<SpriteRenderer>().sprite = LandfillSprite;

                break;

            case 3:
                Debug.Log("3");
                myItem = ItemType.Landfill;
                 this.GetComponent<SpriteRenderer>().sprite = PaperSprite;
                break;

            default:
                print("Nada");
                myItem = ItemType.none;
                break;
        }
    }

    
}
