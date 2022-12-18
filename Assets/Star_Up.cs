using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_Up : MonoBehaviour
{
    private void OnTriggerEnter()
    {
        GameManager.instance.Win();
        Destroy(gameObject);
    }
}
