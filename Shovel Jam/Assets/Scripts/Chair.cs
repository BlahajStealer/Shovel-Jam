using UnityEngine;

public class Chair : MonoBehaviour
{
    public GameObject E;
    public bool inRange;
    PlayerMovement PlayerMovement;
    public GameObject Player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerMovement = Player.GetComponent<PlayerMovement>();
        inRange = false;
        E.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerMovement.inComp == true)
        {
            E.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && PlayerMovement.inComp == false)
        {
            E.SetActive(true);
            if (PlayerMovement.inComp == false)
            {
                inRange = true;

            }
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
