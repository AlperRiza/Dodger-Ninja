using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
// using UnityEngine.UIElements;
using Unity.VisualScripting;
using UnityEngine.UI;

public class ninja_script : MonoBehaviour
{

    public Image can_bari;

    float maxcan = 100.0f;
    float can = 100.0f;
    public Animator anim;
    float hiz = 5;
    Rigidbody yukari;
    bool zipladi = false;
    bool yerde = true;
    public float jumpforce;
    public GameObject panel;

    private void Start()
    {
        yukari = GetComponent<Rigidbody>();

        anim = GetComponent<Animator>();
    }


    void Update()
    {
        /*

        if(Input.GetKeyDown(KeyCode.A)) 
        {
            anim.SetBool("run", true);
        }

        if(Input.GetKeyUp(KeyCode.A)) 
        {
            anim.SetBool("run", false);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetBool("run", true);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("run", false);
        }
        */

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0, 0, hiz * Time.deltaTime);
            Vector3 a = new Vector3 (0, 0, 0);
            transform.eulerAngles = a;
            anim.SetBool("run", true);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0, 0, hiz * Time.deltaTime);
            Vector3 b = new Vector3(0, 180, 0);
            transform.eulerAngles = b;
            anim.SetBool("run", true);
        }

        if (!Input.anyKey)
        {
            anim.SetBool("run", false);
        }
        
        if (Input.GetKeyDown(KeyCode.W) && yerde == true)
        {
            anim.SetTrigger("jump");
            anim.SetTrigger("idle");
            //yukari.velocity = Vector3.up * 400 * Time.deltaTime;
            yukari.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            yerde = false;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Plane")
        {
            zipladi = false;
            yerde = true;
        }

        if (other.gameObject.tag == "top")
        {
            can -= 34.0f;
            Debug.Log("llllllllllll");
            can_bari.fillAmount = can / maxcan;

            if(can <= 0)
            {
                panel.SetActive(true);
                Time.timeScale = 0.0f;
            }
        }
        
    }

    
  









}