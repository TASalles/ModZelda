using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMov : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            
            myAnimationController.SetBool("FWall", true);
            myAnimationController.SetBool("SWall", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationController.SetBool("FWall", false);
            myAnimationController.SetBool("SWall", false);
        }
    }
}
