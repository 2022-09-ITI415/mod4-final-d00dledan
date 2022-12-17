using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;
using UnityEngine.UIElements;

public class InteractScript : MonoBehaviour
{

    public float interactDistance = 5f;
   





    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, interactDistance)) 
            {
                if (hit.collider.CompareTag("Door"))
                {
                    Door doorScript = hit.collider.transform.parent.GetComponent<Door>();
                    if (doorScript == null)
                        return;

                    if (Inventory.Keys[doorScript.index] == true) {
                        doorScript.ChangeDoorState();
                    }


                }
                else if (hit.collider.CompareTag("Key"))
                {
                    Inventory.Keys[hit.collider.GetComponent<Key>().index] = true;
                    
                    Destroy(hit.collider.gameObject);
                }



            } 

        }
    }
}
