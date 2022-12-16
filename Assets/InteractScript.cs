using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InteractScript : MonoBehaviour
{

    public float interactDistance = 1f;

  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, interactDistance)) {
                if (hit.collider.CompareTag("Door"))
                { 
                    hit.collider.transform.parent.GetComponent<Door>().ChangeDoorState();
                }
            } 

        }
    }
}
