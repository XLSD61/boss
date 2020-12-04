using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BuyControl : MonoBehaviour
{
   
    //---------- Gold Value ----------
    public int rugerGold, barelGold, shotgunGold, wincesterGold, dualRevGold, dualShotgunGold;
    //---------- Diamond Value ----------
    public int rugerDia, barelDia, shotgunDia, wincesterDia, dualRevDia, dualShotgunDia;

    //----------Buy Buttons
    public GameObject rugerBuy, barelBuy, shotgunBuy, wincesterBuy, dualRevBuy, dualShotgunBuy;

    //---------Upgrade Button---------------------
    public GameObject rugerBtn, barelBtn, shotgunBtn, wincesterBtn, dualRevBtn, dualShotgunBtn;

    //---------Selected ---------------------
    public GameObject rugerSlected, barelSlected, shotgunSelected, wincesterSelected, dualRevSelected, dualShotgunSelected;


    // Gold and Diamond Text---------
    public Text UpgradeGoldtext, UpgradeDiaText;

    // Go Shop Panels
    public GameObject GoldPanel, DiamondPanel;

    public static int upgradeGold = MainMenucontrol.saveGold;
    public static int upgradeDiamond = MainMenucontrol.saveDiamond;


    private void Start()
    {
        //PlayerPrefs.DeleteAll();


        UpgradeDiaText.text = MainMenucontrol.saveDiamond.ToString(); // toplam altın miktarını yazıyorum
        Debug.Log("elmas" + MainMenucontrol.saveDiamond);
        UpgradeGoldtext.text = MainMenucontrol.saveGold.ToString(); // toplam elmas mikatarını yazıyorum
        Debug.Log("altın" + MainMenucontrol.saveGold);


        if (PlayerPrefs.GetInt("RugerGoldBtn") == 1)
        {
            rugerBuy.SetActive(false);
            rugerBtn.SetActive(true);
            rugerSlected.SetActive(true);
        }
        if (PlayerPrefs.GetInt("RugerDiamondBtn") == 2)
        {
            rugerBuy.SetActive(false);
            rugerBtn.SetActive(true);
            rugerSlected.SetActive(true);
        }
        if (PlayerPrefs.GetInt("BarelGoldBtn") == 3)
        {
            barelBuy.SetActive(false);
            barelBtn.SetActive(true);
            barelSlected.SetActive(true);
        }
        if (PlayerPrefs.GetInt("BarelDiamondBtn") == 4)
        {
            barelBuy.SetActive(false);
            barelBtn.SetActive(true);
            barelSlected.SetActive(true);
        }
        if (PlayerPrefs.GetInt("ShotgunGoldBtn") == 5)
        {
            shotgunBuy.SetActive(false); // satın al butonlarını kaldırıyorum
            shotgunBtn.SetActive(true); // upgrade butonun acıyorum
            shotgunSelected.SetActive(true);
        }
        if (PlayerPrefs.GetInt("ShotgunDiamondBtn") == 6)
        {
            shotgunBuy.SetActive(false); // satın al butonlarını kaldırıyorum
            shotgunBtn.SetActive(true); // upgrade butonun acıyorum
            shotgunSelected.SetActive(true);
        }
        if (PlayerPrefs.GetInt("WincesterGoldBtn") == 7)
        {
            wincesterBuy.SetActive(false);
            wincesterBtn.SetActive(true);
            wincesterSelected.SetActive(true);
        }
        if (PlayerPrefs.GetInt("WincesterDiamondBtn") == 8)
        {
            wincesterBuy.SetActive(false);
            wincesterBtn.SetActive(true);
            wincesterSelected.SetActive(true);
        }
        if (PlayerPrefs.GetInt("DualRevolverGoldBtn") == 9)
        {
            dualRevBuy.SetActive(false);
            dualRevBtn.SetActive(true);
            dualRevSelected.SetActive(true);
        }
        if (PlayerPrefs.GetInt("DualRevolverDiamondBtn") == 10)
        {
            dualRevBuy.SetActive(false);
            dualRevBtn.SetActive(true);
            dualRevSelected.SetActive(true);
        }
        if (PlayerPrefs.GetInt("DualShotgunGoldBtn") == 11)
        {
            dualShotgunBuy.SetActive(false);
            dualShotgunBtn.SetActive(true);
            dualShotgunSelected.SetActive(true);
        }
        if (PlayerPrefs.GetInt("DualShotgunDiamondBtn") == 12)
        {
            dualShotgunBuy.SetActive(false);
            dualShotgunBtn.SetActive(true);
            dualShotgunSelected.SetActive(true);
        }
    }


    //-------------------Ruger Gold
    public  void RugerGoldBtn()
    {
        if(MainMenucontrol.saveGold >= rugerGold)
        {
            MainMenucontrol.saveGold -= rugerGold;
            UpgradeGoldtext.text = MainMenucontrol.saveGold.ToString(); // toplam altın mikatarını yazıyorum
            Debug.Log("Upgrade altın" + MainMenucontrol.saveGold);
            PlayerPrefs.SetInt("RugerGoldBtn", 1);
            rugerBuy.SetActive(false);
            rugerBtn.SetActive(true);
            rugerSlected.SetActive(true);
        }
        else
        {
            GoldPanel.SetActive(true);
        }
    }

    //---------------------Ruger Diamond
    public void RugerDiamondBtn()
    {
        if (MainMenucontrol.saveDiamond >= rugerDia)
        {
            MainMenucontrol.saveDiamond -= rugerDia;
            UpgradeDiaText.text = MainMenucontrol.saveDiamond.ToString(); // toplam elmas mikatarını yazıyorum
            Debug.Log("Upgrade elmas" + MainMenucontrol.saveDiamond);
            PlayerPrefs.SetInt("RugerDiamondBtn",2);
            rugerBuy.SetActive(false);
            rugerBtn.SetActive(true);
            rugerSlected.SetActive(true);
        }
        else
        {
            DiamondPanel.SetActive(true);
        }
    }

    //-----------------Barel Gold---------------
    public void BarelGoldBtn()
    {
        if (MainMenucontrol.saveGold >= barelGold)
        {
            MainMenucontrol.saveGold -= barelGold;
            UpgradeGoldtext.text = MainMenucontrol.saveGold.ToString(); // toplam altın mikatarını yazıyorum
            Debug.Log("Upgrade altın" + MainMenucontrol.saveGold);
            PlayerPrefs.SetInt("BarelGoldBtn", 3);
            barelBuy.SetActive(false);
            barelBtn.SetActive(true);
            barelSlected.SetActive(true);
        }
        else
        {
            GoldPanel.SetActive(true);
        }
    }

    //-----------------Barel Diamond---------------
    public void BarelDiamondBtn()
    {
        if (MainMenucontrol.saveDiamond >= barelDia)
        {
            MainMenucontrol.saveDiamond -= barelDia;
            UpgradeDiaText.text = MainMenucontrol.saveDiamond.ToString(); // toplam altın mikatarını yazıyorum
            Debug.Log("Upgrade elmas" + MainMenucontrol.saveDiamond);
            PlayerPrefs.SetInt("BarelDiamondBtn", 4);
            barelBuy.SetActive(false);
            barelBtn.SetActive(true);
            barelSlected.SetActive(true);
        }
        else
        {
            DiamondPanel.SetActive(true);
        }
    }

    //-----------------Shotgun Gold---------------
    public void ShotgunGoldBtn()
    {
        if (MainMenucontrol.saveGold >= shotgunGold)
        {
            MainMenucontrol.saveGold -= shotgunGold; // altın miktarımdan silah fiyatını düşüyorum
            UpgradeGoldtext.text = MainMenucontrol.saveGold.ToString(); // toplam altın mikatarını yazıyorum
            Debug.Log("Upgrade altın" + MainMenucontrol.saveGold);
            PlayerPrefs.SetInt("ShotgunGoldBtn", 5);
            shotgunBuy.SetActive(false); // satın al butonlarını kaldırıyorum
            shotgunBtn.SetActive(true); // upgrade butonun acıyorum
            shotgunSelected.SetActive(true);
        }
        else
        {
            GoldPanel.SetActive(true);
        }
    }

    //-----------------Shotgun Diamond---------------
    public void ShotgunDiamondBtn()
    {
        if (MainMenucontrol.saveDiamond >= shotgunDia)
        {
            MainMenucontrol.saveDiamond -= shotgunDia;
            UpgradeDiaText.text = MainMenucontrol.saveDiamond.ToString(); // toplam altın mikatarını yazıyorum
            Debug.Log("Upgrade elmas" + MainMenucontrol.saveDiamond);
            PlayerPrefs.SetInt("ShotgunDiamondBtn", 6);
            shotgunBuy.SetActive(false);
            shotgunBtn.SetActive(true);
            shotgunSelected.SetActive(true);
        }
        else
        {
            DiamondPanel.SetActive(true);
        }
    }

    //-----------------Wincester Gold---------------
    public void WincesterGoldBtn()
    {
        if (MainMenucontrol.saveGold >= wincesterGold)
        {
            MainMenucontrol.saveGold -= wincesterGold;
            UpgradeGoldtext.text = MainMenucontrol.saveGold.ToString(); // toplam altın mikatarını yazıyorum
            Debug.Log("Upgrade altın" + MainMenucontrol.saveGold);
            PlayerPrefs.SetInt("WincesterGoldBtn", 7);
            wincesterBuy.SetActive(false);
            wincesterBtn.SetActive(true);
            wincesterSelected.SetActive(true);
        }
        else
        {
            GoldPanel.SetActive(true);
        }
    }

    //-----------------Wincester Diamond---------------
    public void WincesterDiamondBtn()
    {
        if (MainMenucontrol.saveDiamond >= wincesterDia)
        {
            MainMenucontrol.saveDiamond -= wincesterDia;
            UpgradeDiaText.text = MainMenucontrol.saveDiamond.ToString(); // toplam altın mikatarını yazıyorum
            Debug.Log("Upgrade elmas" + MainMenucontrol.saveDiamond);
            PlayerPrefs.SetInt("WincesterDiamondBtn", 8);
            wincesterBuy.SetActive(false);
            wincesterBtn.SetActive(true);
            wincesterSelected.SetActive(true);
        }
        else
        {
            DiamondPanel.SetActive(true);
        }
    }

    //-----------------DualRevolver Gold---------------
    public void DualRevolverGoldBtn()
    {
        if (MainMenucontrol.saveGold >= dualRevGold)
        {
            MainMenucontrol.saveGold -= dualRevGold;
            UpgradeGoldtext.text = MainMenucontrol.saveGold.ToString(); // toplam altın mikatarını yazıyorum
            Debug.Log("Upgrade altın" + MainMenucontrol.saveGold);
            PlayerPrefs.SetInt("DualRevolverGoldBtn", 9);
            dualRevBuy.SetActive(false);
            dualRevBtn.SetActive(true);
            dualRevSelected.SetActive(true);
        }
        else
        {
            GoldPanel.SetActive(true);
        }
    }
    //-----------------DualRevolver Diamond---------------
    public void DualRevolverDiamondBtn()
    {
        if (MainMenucontrol.saveDiamond >= dualRevGold)
        {
            MainMenucontrol.saveDiamond -= dualRevGold;
            UpgradeDiaText.text = MainMenucontrol.saveDiamond.ToString(); // toplam altın mikatarını yazıyorum
            Debug.Log("Upgrade elmas" + MainMenucontrol.saveDiamond);
            PlayerPrefs.SetInt("DualRevolverDiamondBtn", 10);
            dualRevBuy.SetActive(false);
            dualRevBtn.SetActive(true);
            dualRevSelected.SetActive(true);
        }
        else
        {
            DiamondPanel.SetActive(true);
        }
    }

    //-----------------DualShotgun Gold---------------
    public void DualShotgunGoldBtn()
    {
        if (MainMenucontrol.saveGold >= dualShotgunGold)
        {
            MainMenucontrol.saveGold -= dualShotgunGold;
            UpgradeGoldtext.text = MainMenucontrol.saveGold.ToString(); // toplam altın mikatarını yazıyorum
            Debug.Log("Upgrade altın" + MainMenucontrol.saveGold);
            PlayerPrefs.SetInt("DualShotgunGoldBtn", 11);
            dualShotgunBuy.SetActive(false);
            dualShotgunBtn.SetActive(true);
            dualShotgunSelected.SetActive(true);
        }
        else
        {
            GoldPanel.SetActive(true);
        }
    }

    //-----------------DualShotgun Diamond---------------
    public void DualShotgunDiamondBtn()
    {
        if (MainMenucontrol.saveDiamond >= dualShotgunDia)
        {
            MainMenucontrol.saveDiamond -= dualShotgunDia;
            UpgradeDiaText.text = MainMenucontrol.saveDiamond.ToString(); // toplam altın mikatarını yazıyorum
            Debug.Log("Upgrade elmas" + MainMenucontrol.saveDiamond);
            PlayerPrefs.SetInt("DualShotgunDiamondBtn", 12);
            dualShotgunBuy.SetActive(false);
            dualShotgunBtn.SetActive(true);
            dualShotgunSelected.SetActive(true);
        }
        else
        {
            DiamondPanel.SetActive(true);
        }
    }


    //------------------------------------------------------------------------- Popup Panel-----------------------------------------------------------------------------------------------
    public void GoGoldScene()
    {     
        SceneManager.LoadScene("CoinScene"); // altın alma sahnesine gidiş
    }

    public void GoDiamondScene()
    {
        SceneManager.LoadScene("ElmasScene"); // elmas alma sahnesine gidiş
    }

    //-------------------------------------------------------------------------Close  Popup Panel-----------------------------------------------------------------------------------------------
    public void CloseGoldPopupPanel()
    {
        GoldPanel.SetActive(false); // Altın popup kapat
    }
    public void CloseDiamondPopupPanel()
    {
        DiamondPanel.SetActive(false); // Elmas Popup kapat
    } 

}
