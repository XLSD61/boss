using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectScripts : MonoBehaviour
{
    //------------------Selected Image

    public GameObject revolverSlc, rugerSlc, barelSlc, shotgunSlc, wincesterSlc, dualRevSlc, dualShotgunSlc;

    public static bool boolRevolver = false;
    public static bool boolRuger = false;
    public static bool boolBarel = false;
    public static bool boolShotgun = false;
    public static bool boolWinceester = false;
    public static bool boolDualRevolver = false;
    public static bool boolDualShotgun = false;


    private void Start()
    {
        //-------------------------------------------------------------------------------Hangi Silahın Secili olduğunu kontrol etme-----------------------------------------------------------------------
        // Revolver Select 
        if(PlayerPrefs.GetInt("SelectRevolver") == 1)
        {
            //------------------Silah Secme Durumu-----------------------------
            boolRevolver = true;
            boolRuger = false;
            boolBarel = false;
            boolShotgun = false;
            boolWinceester = false;
            boolDualRevolver = false;
            boolDualShotgun = false;
            //------------------------ Silah secme onay kutusu-----------------
            revolverSlc.SetActive(true);
            rugerSlc.SetActive(false);
            barelSlc.SetActive(false);
            shotgunSlc.SetActive(false);
            wincesterSlc.SetActive(false);
            dualRevSlc.SetActive(false);
            dualShotgunSlc.SetActive(false);
            Debug.Log("Revolver secim kaydedildi");
        }

        // Ruger Select
        else if (PlayerPrefs.GetInt("SelectRuger") == 2)
        {
            //------------------Silah Secme Durumu-----------------------------
            boolRevolver = false;
            boolRuger = true;
            boolBarel = false;
            boolShotgun = false;
            boolWinceester = false;
            boolDualRevolver = false;
            boolDualShotgun = false;
            //------------------------ Silah secme onay kutusu-----------------
            rugerSlc.SetActive(true);
            revolverSlc.SetActive(false);
            barelSlc.SetActive(false);
            shotgunSlc.SetActive(false);
            wincesterSlc.SetActive(false);
            dualRevSlc.SetActive(false);
            dualShotgunSlc.SetActive(false);
            Debug.Log("ruger secim kaydedildi");
        }

        // Barel Select
        else if (PlayerPrefs.GetInt("SelectBarel") == 3)
        {
            //------------------Silah Secme Durumu-----------------------------
            boolBarel = true;
            boolRevolver = false;
            boolRuger = false;
            boolShotgun = false;
            boolWinceester = false;
            boolDualRevolver = false;
            boolDualShotgun = false;
            //------------------------ Silah secme onay kutusu-----------------
            barelSlc.SetActive(true);
            revolverSlc.SetActive(false);
            rugerSlc.SetActive(false);
            shotgunSlc.SetActive(false);
            wincesterSlc.SetActive(false);
            dualRevSlc.SetActive(false);
            dualShotgunSlc.SetActive(false);
            Debug.Log("barel secim kaydedildi");
        }

        // Shotgun Select
        else if(PlayerPrefs.GetInt("SelectShotgun") == 4)
        {
            //------------------Silah Secme Durumu-----------------------------
            boolShotgun = true;
            boolRevolver = false;
            boolRuger = false;
            boolBarel = false;
            boolWinceester = false;
            boolDualRevolver = false;
            boolDualShotgun = false;
            //------------------------ Silah secme onay kutusu-----------------
            shotgunSlc.SetActive(true);
            revolverSlc.SetActive(false);
            rugerSlc.SetActive(false);
            barelSlc.SetActive(false);
            wincesterSlc.SetActive(false);
            dualRevSlc.SetActive(false);
            dualShotgunSlc.SetActive(false);
            Debug.Log("shotgun secim kaydedildi");
        }

        // Wincester Select
        else if(PlayerPrefs.GetInt("SelectWincester") == 5)
        {
            //------------------Silah Secme Durumu-----------------------------
            boolWinceester = true;
            boolRevolver = false;
            boolRuger = false;
            boolBarel = false;
            boolShotgun = false;
            boolDualRevolver = false;
            boolDualShotgun = false;
            //------------------------ Silah secme onay kutusu-----------------
            wincesterSlc.SetActive(true);
            revolverSlc.SetActive(false);
            rugerSlc.SetActive(false);
            barelSlc.SetActive(false);
            shotgunSlc.SetActive(false);
            dualRevSlc.SetActive(false);
            dualShotgunSlc.SetActive(false);
            Debug.Log("wincester secim kaydedildi");
        }

        // Dual Revolver Select
        else if(PlayerPrefs.GetInt("SelectDualRevolver") == 6)
        {
            //------------------Silah Secme Durumu-----------------------------
            boolDualRevolver = true;
            boolRevolver = false;
            boolRuger = false;
            boolBarel = false;
            boolShotgun = false;
            boolWinceester = false;
            boolDualShotgun = false;
            //------------------------ Silah secme onay kutusu-----------------
            dualRevSlc.SetActive(true);
            revolverSlc.SetActive(false);
            rugerSlc.SetActive(false);
            barelSlc.SetActive(false);
            shotgunSlc.SetActive(false);
            wincesterSlc.SetActive(false);
            dualShotgunSlc.SetActive(false);
            Debug.Log("dual Revolver secim kaydedildi");
        }

        // Dual Shotgun Select
        else if(PlayerPrefs.GetInt("SelectDualShotgun") == 7)
        {
            //------------------Silah Secme Durumu-----------------------------
            boolDualShotgun = true;
            boolRevolver = false;
            boolRuger = false;
            boolBarel = false;
            boolShotgun = false;
            boolWinceester = false;
            boolDualRevolver = false;
            PlayerPrefs.SetInt("SelectDualShotgun", 7);
            //------------------------ Silah secme onay kutusu-----------------
            dualShotgunSlc.SetActive(true);
            revolverSlc.SetActive(false);
            rugerSlc.SetActive(false);
            barelSlc.SetActive(false);
            shotgunSlc.SetActive(false);
            wincesterSlc.SetActive(false);
            dualRevSlc.SetActive(false);
            Debug.Log("dual shotgun secim kaydedildi");
        }
        //-----------Default Durum
        else
        {
            //------------------Silah Secme Durumu-----------------------------
            boolRevolver = true;
            boolRuger = false;
            boolBarel = false;
            boolShotgun = false;
            boolWinceester = false;
            boolDualRevolver = false;
            boolDualShotgun = false;
            //------------------------ Silah secme onay kutusu-----------------
            revolverSlc.SetActive(true);
            rugerSlc.SetActive(false);
            barelSlc.SetActive(false);
            shotgunSlc.SetActive(false);
            wincesterSlc.SetActive(false);
            dualRevSlc.SetActive(false);
            dualShotgunSlc.SetActive(false);
            Debug.Log("Revolver secim kaydedildi");
        }
       
    }

    public void SelectRevolver()
    {
        //------------------Silah Secme Durumu-----------------------------
        boolRevolver = true;
        boolRuger = false;
        boolBarel = false;
        boolShotgun = false;
        boolWinceester = false;
        boolDualRevolver = false;
        boolDualShotgun = false;
        PlayerPrefs.SetInt("SelectRevolver", 1);
        //------------------------ Silah secme onay kutusu-----------------
        revolverSlc.SetActive(true);
        rugerSlc.SetActive(false);
        barelSlc.SetActive(false);
        shotgunSlc.SetActive(false);
        wincesterSlc.SetActive(false);
        dualRevSlc.SetActive(false);
        dualShotgunSlc.SetActive(false);
        Debug.Log("Revolver secildi");
    }
    //---------------------------------------------------------------------------------Silah Secme Butonları------------------------------------------------------------------------------------------
    public void SelectRuger()
    {
        //------------------Silah Secme Durumu-----------------------------
        boolRevolver = false;
        boolRuger = true;
        boolBarel = false;
        boolShotgun = false;
        boolWinceester = false;
        boolDualRevolver = false;
        boolDualShotgun = false;
        //GunControl.rugerBool = true;
        PlayerPrefs.SetInt("SelectRuger", 2);
        //------------------------ Silah secme onay kutusu-----------------
        rugerSlc.SetActive(true);
        revolverSlc.SetActive(false);
        
        barelSlc.SetActive(false);
        shotgunSlc.SetActive(false);
        wincesterSlc.SetActive(false);
        dualRevSlc.SetActive(false);
        dualShotgunSlc.SetActive(false);
        Debug.Log("ruger secildi");
    }
    public void SelectBarel()
    {
        //------------------Silah Secme Durumu-----------------------------
        boolBarel = true;
        boolRevolver = false;
        boolRuger = false;        
        boolShotgun = false;
        boolWinceester = false;
        boolDualRevolver = false;
        boolDualShotgun = false;
        //GunControl.barelBool = true;
        PlayerPrefs.SetInt("SelectBarel", 3);
        //------------------------ Silah secme onay kutusu-----------------
        barelSlc.SetActive(true);
        revolverSlc.SetActive(false);
        rugerSlc.SetActive(false);
       
        shotgunSlc.SetActive(false);
        wincesterSlc.SetActive(false);
        dualRevSlc.SetActive(false);
        dualShotgunSlc.SetActive(false);
        Debug.Log("barel secildi");
    }
    public void SelectShotgun()
    {
        //------------------Silah Secme Durumu-----------------------------
        boolShotgun = true;
        boolRevolver = false;
        boolRuger = false;
        boolBarel = false;       
        boolWinceester = false;
        boolDualRevolver = false;
        boolDualShotgun = false;
        PlayerPrefs.SetInt("SelectShotgun", 4);
        //------------------------ Silah secme onay kutusu-----------------
        shotgunSlc.SetActive(true);
        revolverSlc.SetActive(false);
        rugerSlc.SetActive(false);
        barelSlc.SetActive(false);      
        wincesterSlc.SetActive(false);
        dualRevSlc.SetActive(false);
        dualShotgunSlc.SetActive(false);
        Debug.Log("shotgun secildi");
    }
    public void SelectWincester()
    {
        //------------------Silah Secme Durumu-----------------------------
        boolWinceester = true;
        boolRevolver = false;
        boolRuger = false;
        boolBarel = false;
        boolShotgun = false;    
        boolDualRevolver = false;
        boolDualShotgun = false;
        PlayerPrefs.SetInt("SelectWincester", 5);
        //------------------------ Silah secme onay kutusu-----------------
        wincesterSlc.SetActive(true);
        revolverSlc.SetActive(false);
        rugerSlc.SetActive(false);
        barelSlc.SetActive(false);
        shotgunSlc.SetActive(false);      
        dualRevSlc.SetActive(false);
        dualShotgunSlc.SetActive(false);
        Debug.Log("wincester secildi");
    }
    public void SelectDualRevolver()
    {
        //------------------Silah Secme Durumu-----------------------------
        boolDualRevolver = true;
        boolRevolver = false;
        boolRuger = false;
        boolBarel = false;
        boolShotgun = false;
        boolWinceester = false;       
        boolDualShotgun = false;
        PlayerPrefs.SetInt("SelectDualRevolver", 6);
        //------------------------ Silah secme onay kutusu-----------------
        dualRevSlc.SetActive(true);
        revolverSlc.SetActive(false);
        rugerSlc.SetActive(false);
        barelSlc.SetActive(false);
        shotgunSlc.SetActive(false);
        wincesterSlc.SetActive(false);        
        dualShotgunSlc.SetActive(false);
        Debug.Log("dual revolver secildi");
    }
    public void SelectDualShotgun()
    {
        //------------------Silah Secme Durumu-----------------------------
        boolDualShotgun = true;
        boolRevolver = false;
        boolRuger = false;
        boolBarel = false;
        boolShotgun = false;
        boolWinceester = false;
        boolDualRevolver = false;       
        PlayerPrefs.SetInt("SelectDualShotgun", 7);
        //------------------------ Silah secme onay kutusu-----------------
        dualShotgunSlc.SetActive(true);
        revolverSlc.SetActive(false);
        rugerSlc.SetActive(false);
        barelSlc.SetActive(false);
        shotgunSlc.SetActive(false);
        wincesterSlc.SetActive(false);
        dualRevSlc.SetActive(false);
        Debug.Log("ddual shotgun secildi");
    }
}


 
