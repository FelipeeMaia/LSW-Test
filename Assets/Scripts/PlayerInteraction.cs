using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private float radius;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Physics2D.OverlapCircleNonAlloc(transform.position, radius, )
    }

    public void CheckForInteractable(Vector2 pointOfInteraction)
    {
        RaycastHit2D hit;


    }

    // Decide: MouseClick interaction, or raycastSearch interaction
    // Get mouse position, and raycast to screen and try to find an interactable
}
