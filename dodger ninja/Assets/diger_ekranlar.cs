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
        // 1 dakika süresi olsun
        countdownText = GameObject.Find("Canvas/countdownText").GetComponent<TextMeshProUGUI>();
        // Geri sayým iþlemini baþlat
        StartCoroutine(StartCountdown(countdownTime));

    }

    IEnumerator StartCountdown(int countdownTime)
    {
        // Süreyi saniye cinsinden tutalým
        int countdownTimeInSeconds = countdownTime;

        // Süre bitene kadar geri sayým iþlemini sürdür
        while (countdownTimeInSeconds > 0)
        {
            // Geri sayým metnini güncelle

            countdownText.text = countdownTime + " Saniyen Kaldý";
            // Bir saniye bekle
            yield return new WaitForSeconds(1);

            // Süreyi 1 saniye azalt
            countdownTimeInSeconds--;
            countdownTime--;
        }


        // Geri sayým bittiðinde "Time's up!" metnini göster
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
        // Oyunu tekrar baþlat
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1.0f;
    }

}