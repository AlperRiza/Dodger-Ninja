using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class engel1 : MonoBehaviour
{


    private void FixedUpdate()
    {
        transform.Translate(0, 0, -5 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Destroyer1")
        {
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "ninja")
        {
            Destroy(this.gameObject);
        }
    }







    /*
    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0.0f, 0.0f, -5.0f);
    }
    */
}
