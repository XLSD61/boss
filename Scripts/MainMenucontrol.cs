using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenucontrol : MonoBehaviour
{

    // Oyun baslangıc kontrol
    public static int startGame = 1;


    //---- Diamond------
    public Text mainDiamond;
    public static int saveDiamond;
    int totalDiamond;


    //------Gold--------
    public Text mainGold;
    public static int saveGold;
    int totalGold;

    //--------------Panels--------------
    public GameObject upgradePanel, goldPanel, diamondPanel;

    private void Awake()
    {
        //PlayerPrefs.DeleteAll();

        if(startGame == 1)
        {
            //-----Diamond------------
            totalDiamond = PlayerPrefs.GetInt("savediamond");
            saveDiamond = totalDiamond;

            //--------Gold-----------
            totalGold = PlayerPrefs.GetInt("savegold");
            saveGold = totalGold;
        }
       
    }
    private void Start()
    {
        UpgradeDef();
        Debug.Log("Start kayıtlı speed " + PlayerPrefs.GetFloat("playerspeed"));
        //------Diamond------
        saveDiamond += PlayerPrefs.GetInt("diamond");
        mainDiamond.text = saveDiamond.ToString();
        PlayerPrefs.SetInt("savediamond", saveDiamond);

        //-------Gold--------
        saveGold += PlayerPrefs.GetInt("gold");
        mainGold.text = saveGold.ToString();
        PlayerPrefs.SetInt("savegold", saveGold);
    }

    void UpgradeDef() // Upgrade Conrol Scriptim de kaydettiğim güncel uğgrade değerlerini burada cağırırıyorum bu foknsiyon start içinde cağrıılr
    {
        //Health Upgrades
        FPSControl.playerHealth = PlayerPrefs.GetInt("playerhealth", 100);
        Debug.Log("Player Health Start " + FPSControl.playerHealth);

        // Speed Upgrades
        FPSControl.speed = PlayerPrefs.GetFloat("playerspeed", 5.0f);
        Debug.Log("Player Speed Start " + FPSControl.speed);

        //Medkit Upgrades
        FPSControl.medkitPlus = PlayerPrefs.GetInt("medkitplus", 20);
        Debug.Log("Medkit Start " + FPSControl.medkitPlus);

        //-------------------------------------------------AmmoBox Upgrades--------------------------------------------------------------
        //--Dual Shotgun
        DualShotgun.bulletCountPlus = PlayerPrefs.GetInt("ammodualshotgun",12);
        Debug.Log("Dual Shotgun Ammo Start " + DualShotgun.bulletCountPlus);
        //--Dual Revolver
        DualRevControl.bulletCountPlus = PlayerPrefs.GetInt("ammodualrev", 18);
        Debug.Log("Dual Revolver Ammo Start " + DualRevControl.bulletCountPlus);
        //--Dual Ruger
        DualRugControl.bulletCountPlus = PlayerPrefs.GetInt("ammodualrug", 18);
        Debug.Log("Dual Ruger Ammo Start " + DualRugControl.bulletCountPlus);
        //--Wincester
        WincesterControl.bulletCountPlus = PlayerPrefs.GetInt("ammowincester", 8);
        Debug.Log("Wincester Ammo Start " + WincesterControl.bulletCountPlus);
        //--Shotgun
        ShotgunControl.bulletCountPlus = PlayerPrefs.GetInt("ammoshotgun", 8);
        Debug.Log("Shotgun Start " + ShotgunControl.bulletCountPlus);
        //--Barel
        SShotgunContro.bulletCountPlus = PlayerPrefs.GetInt("ammobarel", 12);
        Debug.Log("Shotgun Start " + SShotgunContro.bulletCountPlus);
        //--Ruger
        RugerControl.bulletCountPlus = PlayerPrefs.GetInt("ammoruger", 16);
        Debug.Log("Shotgun Start " + RugerControl.bulletCountPlus);
        //--Revolver
        WeaponControl.bulletCountPlus = PlayerPrefs.GetInt("ammorevolver", 16);
        Debug.Log("Shotgun Start " + WeaponControl.bulletCountPlus);

    }

    public void StartGamme()
    {
        startGame =2;
        SceneManager.LoadScene("GameScene");
        CamControl.goldCount = 0;
        CamControl.score = 0;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void UpgradeMenu()
    {
        startGame = 2;
        upgradePanel.SetActive(true);
    }

    public void DiamondScene()
    {
        startGame = 2;
        diamondPanel.SetActive(true);
    }

    public void GoldScene()
    {
        startGame = 2;
        goldPanel.SetActive(true);
    }

    public void Credits()
    {

    }
    //--------------------------------------------------------------Panel Close----------------------------------------------------------------
    public void CloseUpgradePanel()
    {
        upgradePanel.SetActive(false);
        mainGold.text = saveGold.ToString();
        mainDiamond.text = saveDiamond.ToString();
    }
    public void CloseGoldPanel()
    {
        goldPanel.SetActive(false);
        mainGold.text = saveGold.ToString();
        mainDiamond.text = saveDiamond.ToString();
    }
    public void CloseDiamondPanel()
    {
        diamondPanel.SetActive(false);
        mainGold.text = saveGold.ToString();
        mainDiamond.text = saveDiamond.ToString();
    }
}
