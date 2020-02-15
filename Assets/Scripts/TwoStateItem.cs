using UnityEngine;

// Represents two-state items like a cardboard box that has to be 'crushed' before being put into a bin
public class TwoStateItem : MonoBehaviour
{
    public SpriteRenderer SpriteRenderer;
    public Sprite InitialState;
    public Sprite FinalState;
    public DragAndDrop DragAndDrop;
    public RecyclingItem RecyclingItem;

    private bool m_IsDone;

    private void Start()
    {
        SpriteRenderer.sprite = InitialState;
        DragAndDrop.enabled = false;
        m_RecyclingItemType = RecyclingItem.ItemType;
        // Set the type to -1 until they tap it
        RecyclingItem.ItemType = -1;
    }

    private void OnMouseUpAsButton()
    {
        if (!m_IsDone)
        {
            m_IsDone = true;
            SpriteRenderer.sprite = FinalState;
            DragAndDrop.enabled = true;
            //Set back the initial item type
            RecyclingItem.ItemType = m_RecyclingItemType;
        }
    }

    [SerializeField]
    [HideInInspector]
    private int m_RecyclingItemType;
}
