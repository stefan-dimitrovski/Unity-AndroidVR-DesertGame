using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignEventCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Canvas canvas = GetComponent<Canvas>();
        if (canvas && canvas.worldCamera == null)
        {
            canvas.worldCamera = Camera.main;
        }
    }
}
