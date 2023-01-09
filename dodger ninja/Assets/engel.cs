using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class engel : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.Translate(0, 0, 5 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Destroyer")
        {
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "ninja")
        {
            Destroy(this.gameObject);
        }
    }



}
