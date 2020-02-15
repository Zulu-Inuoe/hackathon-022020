using UnityEngine;
using UnityEngine.UI;

// Represents two-state items like a cardboard box that has to be 'crushed' before being put into a bin
public class TwoStateItem : MonoBehaviour
{
    public Image Image;
    public Sprite InitialState;
    public Sprite FinalState;
    public DragAndDrop DragAndDrop;

    private bool m_IsDone;

    private void Start()
    {
        Image.sprite = InitialState;
        DragAndDrop.enabled = false;
    }


    private void OnMouseUpAsButton()
    {
        if (!m_IsDone)
        {
            m_IsDone = true;
            Image.sprite = FinalState;
            DragAndDrop.enabled = true;
        }
    }

}
