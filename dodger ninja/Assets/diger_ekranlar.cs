using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class diger_ekranlar : MonoBehaviour
{
    TextMeshProUGUI countdownText;
    public int countdownTime;
    public GameObject panel;
    void Start()
    {
        // 1 dakika s�resi olsun
        countdownText = GameObject.Find("Canvas/countdownText").GetComponent<TextMeshProUGUI>();
        // Geri say�m i�lemini ba�lat
        StartCoroutine(StartCountdown(countdownTime));

    }

    IEnumerator StartCountdown(int countdownTime)
    {
        // S�reyi saniye cinsinden tutal�m
        int countdownTimeInSeconds = countdownTime;

        // S�re bitene kadar geri say�m i�lemini s�rd�r
        while (countdownTimeInSeconds > 0)
        {
            // Geri say�m metnini g�ncelle

            countdownText.text = countdownTime + " Saniyen Kald�";
            // Bir saniye bekle
            yield return new WaitForSeconds(1);

            // S�reyi 1 saniye azalt
            countdownTimeInSeconds--;
            countdownTime--;
        }


        // Geri say�m bitti�inde "Time's up!" metnini g�ster
        countdownText.text = "you win!";
        panel.SetActive(true);
        Time.timeScale = 0.0f;
    }
    public void youLose()
    {
        countdownText.text = "you lose!";
    }

    public void TekrarOyna()
    {
        // Oyunu tekrar ba�lat
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1.0f;
    }

}