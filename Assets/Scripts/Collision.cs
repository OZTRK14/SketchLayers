using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Collision : MonoBehaviour
{
    public Animator animator;


    private void OnTriggerEnter(Collider other)
    {

        if(other.CompareTag("Cube"))
        {
            animator.SetTrigger("Kikk");
        }
        if(other.CompareTag("Trambol1"))
        {

            transform.DOJump(new Vector3(transform.position.x, transform.position.y + 4, transform.position.z + 8), 1f, 1, .5f).OnComplete(() => transform.DOJump(new Vector3(transform.position.x, 50, transform.position.z +80), 5, 1, 1.5f));
            //* transform.position = Vector3.Lerp(transform.position,new Vector3(transform.position.x,transform.position.y+5,transform.position.z+5),.75f);
        }
        if(other.CompareTag("Go"))
        {
            transform.DOMoveZ(( transform.position.z + 100), .5f);
        }

    }

   
 
}
