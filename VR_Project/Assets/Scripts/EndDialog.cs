using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndDialog : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            Debug.Log("Cancel Clicked!!");
            SceneManager.LoadScene("QuitMenu");
        }
    }
}
