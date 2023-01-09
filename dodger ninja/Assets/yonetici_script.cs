using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yonetici_script : MonoBehaviour
{
    float rast = 2.0f;

    public GameObject Engel_sag;
    public GameObject Engel_sol;

    bool oyunu_kazandin = false;
    bool oyunu_kaybettin = false;

    private void Start()
    {
        InvokeRepeating("AAA", 0.0f, 2.0f);
    }

    void AAA()
    {
        Invoke("BBB", rast);
        rast = Random.Range(2.0f, 3.0f);
    }
    void BBB()
    {
        Engel_Ekle();
    }

    void Engel_Ekle()
    {
        int rnd = Random.Range(0, 3);

        if (rnd == 0)
        {
            GameObject yeni_engel = Instantiate(Engel_sag, new Vector3(1.23f, 3.03f, -11.2f), Quaternion.identity);
        }
        else if(rnd == 1)
        {
            GameObject yeni_engel1 = Instantiate(Engel_sol, new Vector3(1.23f, 3.03f, 6.84f), Quaternion.identity);
        }
        else
        {
            GameObject yeni_engel = Instantiate(Engel_sag, new Vector3(1.23f, 3.03f, -11.2f), Quaternion.identity);

            GameObject yeni_engel1 = Instantiate(Engel_sol, new Vector3(1.23f, 3.03f, 6.84f), Quaternion.identity);
        }
    }


}
