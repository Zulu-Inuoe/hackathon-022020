using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    public float RPM;

    private RectTransform m_Transform;

    private void Start()
    {
        m_Transform = GetComponent<RectTransform>();
    }

    private void FixedUpdate()
    {
        var rotation = RPM * (Time.fixedDeltaTime / 60) * 360;
        m_Transform.Rotate(0, 0, rotation);
    }
}
