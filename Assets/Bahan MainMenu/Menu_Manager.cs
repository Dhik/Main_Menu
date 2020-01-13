using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Manager : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject CreditsPanel;
    public GameObject HowtoPanel;
    public GameObject MenPanel;
    public GameObject CreditPanel;
    public GameObject HowtPanel;
    public GameObject MePanel;
    public GameObject CrediPanel;
    public GameObject HowPanel;
    void Start()
    {
        MenuPanel.SetActive(true);
        CreditsPanel.SetActive(false);
        HowtoPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayButtonClicked()
    {
        Application.LoadLevel("AR Game");
    }
    public void CreditsButtonClicked()
    {
        MenuPanel.SetActive(false);
        CreditsPanel.SetActive(true);
        HowtoPanel.SetActive(false);
    }
    public void HowtoButtonClicked()
    {
        MenuPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        HowtoPanel.SetActive(true);
    }
    public void Quit_Clicked()
    {
        Application.Quit();
    }
    public void BackButtonClicked()
    {
        MenuPanel.SetActive(true);
        CreditsPanel.SetActive(false);
        HowtoPanel.SetActive(false);
    }
}
