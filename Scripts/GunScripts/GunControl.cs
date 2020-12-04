using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControl : MonoBehaviour
{
    // ----------------------Guns---------------------------------------------

    public GameObject revolver, ruger, barel, shotgun, wincester, dualRevolver, dualSshotgun;

    //----------------------Bools
    public static bool revolverBool = true; 
    public static bool rugerBool = false;
    public static bool barelBool = false;
    public static bool shotgunBool = false;
    public static bool wincesterBool = false;
    public static bool dualRevolverBool = false;
    public static bool dualSshotgunBool = false;

    private void Start()
    {

        // Revolver
        if (SelectScripts.boolRevolver)
        {
            revolver.SetActive(true);
            ruger.SetActive(false);
            barel.SetActive(false);
            shotgun.SetActive(false);
            wincester.SetActive(false);
            dualRevolver.SetActive(false);
            dualSshotgun.SetActive(false);
        }


        // Ruger
        else if (SelectScripts.boolRuger)
        {
            ruger.SetActive(true);
            revolver.SetActive(false);

            barel.SetActive(false);
            shotgun.SetActive(false);
            wincester.SetActive(false);
            dualRevolver.SetActive(false);
            dualSshotgun.SetActive(false);
        }

        // Barel
        else if (SelectScripts.boolBarel)
        {
            barel.SetActive(true);
            revolver.SetActive(false);
            ruger.SetActive(false);
           
            shotgun.SetActive(false);
            wincester.SetActive(false);
            dualRevolver.SetActive(false);
            dualSshotgun.SetActive(false);
        }

        // Shotgun
        else if (SelectScripts.boolDualShotgun)
        {
            shotgun.SetActive(true);
            revolver.SetActive(false);
            ruger.SetActive(false);
            barel.SetActive(false);

            wincester.SetActive(false);
            dualRevolver.SetActive(false);
            dualSshotgun.SetActive(false);
        }

        // wincester
        else if (SelectScripts.boolWinceester)
        {
            wincester.SetActive(true);
            revolver.SetActive(false);
            ruger.SetActive(false);
            barel.SetActive(false);
            shotgun.SetActive(false);
           
            dualRevolver.SetActive(false);
            dualSshotgun.SetActive(false);
        }

        // Dual Revolver
        else if (SelectScripts.boolDualRevolver)
        {
            dualRevolver.SetActive(true);
            revolver.SetActive(false);
            ruger.SetActive(false);
            barel.SetActive(false);
            shotgun.SetActive(false);
            wincester.SetActive(false);
            
            dualSshotgun.SetActive(false);
        }

        // Dual Shotgun
        else if (SelectScripts.boolDualShotgun)
        {
            dualSshotgun.SetActive(true);
            revolver.SetActive(false);
            ruger.SetActive(false);
            barel.SetActive(false);
            shotgun.SetActive(false);
            wincester.SetActive(false);
            dualRevolver.SetActive(false);
           
        }

    }


    private void Update()
    {
        // Revolver
        if (Input.GetKeyDown(KeyCode.F1))
        {
            revolver.SetActive(true);
            ruger.SetActive(false);
            barel.SetActive(false);
            shotgun.SetActive(false);
            wincester.SetActive(false);
            dualRevolver.SetActive(false);
            dualSshotgun.SetActive(false);
        }


        // Ruger
        else if (Input.GetKeyDown(KeyCode.F2))
        {
            ruger.SetActive(true);
            revolver.SetActive(false);

            barel.SetActive(false);
            shotgun.SetActive(false);
            wincester.SetActive(false);
            dualRevolver.SetActive(false);
            dualSshotgun.SetActive(false);
        }

        // Barel
        else if (Input.GetKeyDown(KeyCode.F3))
        {
            barel.SetActive(true);
            revolver.SetActive(false);
            ruger.SetActive(false);

            shotgun.SetActive(false);
            wincester.SetActive(false);
            dualRevolver.SetActive(false);
            dualSshotgun.SetActive(false);
        }

        // Shotgun
        else if (Input.GetKeyDown(KeyCode.F4))
        {
            shotgun.SetActive(true);
            revolver.SetActive(false);
            ruger.SetActive(false);
            barel.SetActive(false);

            wincester.SetActive(false);
            dualRevolver.SetActive(false);
            dualSshotgun.SetActive(false);
        }

        // wincester
        else if (Input.GetKeyDown(KeyCode.F5))
        {
            wincester.SetActive(true);
            revolver.SetActive(false);
            ruger.SetActive(false);
            barel.SetActive(false);
            shotgun.SetActive(false);

            dualRevolver.SetActive(false);
            dualSshotgun.SetActive(false);
        }

        // Dual Revolver
        else if (Input.GetKeyDown(KeyCode.F6))
        {
            dualRevolver.SetActive(true);
            revolver.SetActive(false);
            ruger.SetActive(false);
            barel.SetActive(false);
            shotgun.SetActive(false);
            wincester.SetActive(false);

            dualSshotgun.SetActive(false);
        }

        // Dual Shotgun
        else if (Input.GetKeyDown(KeyCode.F7))
        {
            dualSshotgun.SetActive(true);
            revolver.SetActive(false);
            ruger.SetActive(false);
            barel.SetActive(false);
            shotgun.SetActive(false);
            wincester.SetActive(false);
            dualRevolver.SetActive(false);

        }
    }

}
