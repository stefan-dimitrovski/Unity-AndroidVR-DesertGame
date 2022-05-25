using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public GameHandler GH;
    public AudioClip CoinSound;
    // Start is called before the first frame update
    void Start()
    {
        GH = GameObject.Find("Score").GetComponent<GameHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        GH.Coins++;
        AudioSource.PlayClipAtPoint(CoinSound, transform.position);
        Destroy(gameObject);
    }
}
