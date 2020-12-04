using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradePanel : MonoBehaviour
{
    //---------Panels---------------------
    public GameObject cowboyPanel, medkitPanel, ammoboxPanel, revolverPanel, rugerPanel, barelPanel, shotgunPanel, wincesterPanel, dualRevPanel, dualShotgunPanel;
    


    //------------Panel Control---------------
    public void CowboyUpgradeBtn()
    {
        cowboyPanel.SetActive(true); //Cowbow upgrade panelini acıyorum
    }
    public void MedkitUpgradeBtn()
    {
        medkitPanel.SetActive(true);//medkit upgrade panelini acıyorum
    }
    public void AmmoBoxUpgradeBtn()
    {
        ammoboxPanel.SetActive(true);//ammobox upgrade panelini acıyorum
    }
    public void RevolverUpgradeBtn()
    {
        revolverPanel.SetActive(true);//revolver upgrade panelini acıyorum
    }
    public void RugerUpgradeBtn()
    {
        rugerPanel.SetActive(true);//ruger upgrade panelini acıyorum
    }
    public void BarelUpgradeBtn()
    {
        barelPanel.SetActive(true);//barel upgrade panelini acıyorum
    }
    public void ShotgunUpgradeBtn()
    {
        shotgunPanel.SetActive(true);//shotgun upgrade panelini acıyorum
    }
    public void WincesterUpgradeBtn()
    {
        wincesterPanel.SetActive(true);//wibcester upgrade panelini acıyorum
    }
    public void DualRevUpgradeBtn()
    {
        dualRevPanel.SetActive(true);//duralrevolver upgrade panelini acıyorum
    }
    public void DualShotgunUpgradeBtn()
    {
        dualShotgunPanel.SetActive(true);//dualshotgun upgrade panelini acıyorum
    }

    //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

    //------------Exit Panel Button Control---------------
    public void ExitCowboyUpgradeBtn() 
    {
        cowboyPanel.SetActive(false); //Cowbow upgrade panelini acıyorum
    }
    public void ExitMedkitUpgradeBtn()
    {
        medkitPanel.SetActive(false);//medkit upgrade panelini acıyorum
    }
    public void ExitAmmoBoxUpgradeBtn()
    {
        ammoboxPanel.SetActive(false);//ammobox upgrade panelini acıyorum
    }
    public void ExitRevolverUpgradeBtn()
    {
        revolverPanel.SetActive(false);//revolver upgrade panelini acıyorum
    }
    public void ExitRugerUpgradeBtn()
    {
        rugerPanel.SetActive(false);//ruger upgrade panelini acıyorum
    }
    public void ExitBarelUpgradeBtn()
    {
        barelPanel.SetActive(false);//barel upgrade panelini acıyorum
    }
    public void ExitShotgunUpgradeBtn()
    {
        shotgunPanel.SetActive(false);//shotgun upgrade panelini acıyorum
    }
    public void ExitWincesterUpgradeBtn()
    {
        wincesterPanel.SetActive(false);//wibcester upgrade panelini acıyorum
    }
    public void ExitDualRevUpgradeBtn()
    {
        dualRevPanel.SetActive(false);//duralrevolver upgrade panelini acıyorum
    }
    public void ExitDualShotgunUpgradeBtn()
    {
        dualShotgunPanel.SetActive(false);//dualshotgun upgrade panelini acıyorum
    }


}
