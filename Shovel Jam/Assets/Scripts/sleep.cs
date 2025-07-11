using UnityEngine;

public class sleep : MonoBehaviour
{
    public GameObject E;
    public GameObject Player;
    public bool inRange;
    PlayerMovement playerMovement;

    void Start()
    {
        playerMovement = Player.GetComponent<PlayerMovement>();
        E.SetActive(false);
        inRange = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            E.SetActive(true);
            inRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            E.SetActive(false);
            inRange = false;
        }
    }
}
