using UnityEngine;

public class animation : MonoBehaviour
{
    public Animator animator;
    public string animationName;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void AnimRestart()
    {
        animator.Play(animationName, -1, 0f);
    }
}
