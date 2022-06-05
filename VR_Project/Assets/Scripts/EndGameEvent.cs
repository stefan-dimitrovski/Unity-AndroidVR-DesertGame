using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameEvent : MonoBehaviour
{
    public GameHandler GH;

    void Start()
    {
        GH = GameObject.Find("Score").GetComponent<GameHandler>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish" && GH.Coins == 5)
        {
            SceneManager.LoadScene("QuitMenu");
        }
        else if (other.tag == "Respawn")
        {
            SceneManager.LoadScene("QuitMenu");
        }
    }
}
