using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//******************************************** Bu kod Main Menüdeki canvasın içindedir***************************************************************
public class UpgradeControl : MonoBehaviour
{
    

    //-----------------------------Slider Tanımlama-------------------------
    public Slider healthSlider, speedSlider,medkitSlider,ammoboxSlider;

    //-----------------------------Değer Tanımlama---------------------------
    public int maxHealth, maxSpeed,maxMedkit,maxAmmobox;

    //---------------------------Baslangıc Değeri Tanımlama--------------------
    int currentHealth, currentSpeed,currentMedkit,currentAmmobox;

    // -----------------Upgrade Butonları Değer Textleri-------------------------
    public Text healthGoldText, healthDiamondText, speedGoldText, speedDiamondText, medkitGoldText, medkitDiamondText, ammoboxGoldText, ammoboxDiamondText;

    // -------------Gold ve Diamond Text---------------------------------
    public Text upGoldText, upDiamondText;

    //--------------- Upgarade Değerleri-------------------- 
    public int healthGoldValue, healthDiamondValue, speedGoldValue, speedDiamondValue;
    public int medkitGoldValue, medkitDiamondValue;
    public int ammoboxGoldValue, ammoboxDiamondValue;

    void Start()
    {
        SefDefs();
        StartText();
    }

    void SefDefs()
    {
        //----Values
        healthGoldValue = PlayerPrefs.GetInt("healthgold",5);
        healthDiamondValue = PlayerPrefs.GetInt("healthdiamond",2);
        speedGoldValue = PlayerPrefs.GetInt("speedgold",5);
        speedDiamondValue = PlayerPrefs.GetInt("speediamond",2);
        medkitGoldValue = PlayerPrefs.GetInt("medkitgold",5);
        medkitDiamondValue = PlayerPrefs.GetInt("medkitdiamond",2);
        ammoboxGoldValue = PlayerPrefs.GetInt("ammoboxgold",5);
        ammoboxDiamondValue = PlayerPrefs.GetInt("ammoboxdiamond",2);


        //----Slider
        currentHealth = PlayerPrefs.GetInt("health", 0);
        currentSpeed = PlayerPrefs.GetInt("speed", 0);
        currentMedkit = PlayerPrefs.GetInt("medkit", 0);
        currentAmmobox = PlayerPrefs.GetInt("ammobox", 0);

        healthSlider.maxValue = maxHealth;
        speedSlider.maxValue = maxSpeed;
        medkitSlider.maxValue = maxMedkit;
        ammoboxSlider.maxValue = maxAmmobox;

        healthSlider.value = currentHealth;
        speedSlider.value = currentSpeed;
        medkitSlider.value = currentMedkit;
        ammoboxSlider.value = currentAmmobox;
    }

    void StartText()
    {
        //--------Health
        healthGoldText.text = healthGoldValue.ToString();
        healthDiamondText.text = healthDiamondValue.ToString();

        //-------Speed
        speedGoldText.text = speedGoldValue.ToString();
        speedDiamondText.text = speedDiamondValue.ToString();

        //---------Medkit
        medkitGoldText.text = PlayerPrefs.GetInt("medkitgold").ToString();
        medkitDiamondText.text = PlayerPrefs.GetInt("medkitdiamond").ToString();

        //--------Ammobox
        ammoboxGoldText.text = PlayerPrefs.GetInt("ammoboxgold").ToString();
        ammoboxDiamondText.text = PlayerPrefs.GetInt("ammoboxdiamond").ToString();
    }


    public void BuyGoldHealth()
    {
        if(MainMenucontrol.saveGold >= healthGoldValue)
        {
            if (currentHealth < maxHealth)
            {
                //------Upgrade Codes
                FPSControl.playerHealth += 10; // Karakterin canını 10 artırıyor
                PlayerPrefs.SetInt("playerhealth", FPSControl.playerHealth);
                Debug.Log("Player Health +10 " + FPSControl.playerHealth);

                //-------Slider
                currentHealth += 20; // Slider değerini artır 100 üzerinden hesaplanır 
                PlayerPrefs.SetInt("health", currentHealth); // artırdığım değeri kaydediyorum
                healthSlider.value = currentHealth;// Slider değerini artır 100 üzerinden hesaplanır 

                //Money
                healthGoldValue += 5;
                healthGoldText.text = healthGoldValue.ToString();
                PlayerPrefs.SetInt("healthgold", healthGoldValue);//Güncel upgrade ücretini kaydediyorum
                healthDiamondValue += 2;
                healthDiamondText.text = healthDiamondValue.ToString();
                PlayerPrefs.SetInt("healthdiamond ", healthDiamondValue);//Güncel upgrade ücretini kaydediyorum

                //Text
                MainMenucontrol.saveGold -= healthGoldValue; // Altın miktarımdan upgrade ücretini düşüyorum
                upGoldText.text = MainMenucontrol.saveGold.ToString(); // altın textime yeni değeri yazıyorum 

                Debug.Log("Upgrade Health Succesfull");

            }
            else
            {
                //---------------Kod gelecek
                Debug.Log("Healh Full");
            }
        }
        else
        {
            // Altın veya Elmas paneline git kodları gelecek
        }
       
    }
    public void BuyDiamondHealth()
    {
        if (MainMenucontrol.saveDiamond >= healthDiamondValue)
        {
            if (currentHealth < maxHealth)
            {
                //------Upgrade Codes
                FPSControl.playerHealth += 10; // Karakterin canını 10 artııryor
                PlayerPrefs.SetInt("playerhealth", FPSControl.playerHealth);
                Debug.Log("Player Health +10 " + FPSControl.playerHealth);

                //-------Slider
                currentHealth += 20; // Slider değerini artır 100 üzerinden hesaplanır 
                PlayerPrefs.SetInt("health", currentHealth); // artırdığım değeri kaydediyorum
                healthSlider.value = currentHealth;// Slider değerini artır 100 üzerinden hesaplanır 
                Debug.Log("Upgrade Health Succesfull");

                //Money
                healthGoldValue += 5;
                healthGoldText.text = healthGoldValue.ToString();
                PlayerPrefs.SetInt("healthgold", healthGoldValue);//Güncel upgrade ücretini kaydediyorum
                healthDiamondValue += 2;
                healthDiamondText.text = healthDiamondValue.ToString();
                PlayerPrefs.SetInt("healthdiamond", healthDiamondValue);//Güncel upgrade ücretini kaydediyorum

                //Text
                MainMenucontrol.saveDiamond -= healthDiamondValue; // Elmas miktarımdan upgrade ücretini düşüyorum
                upDiamondText.text = MainMenucontrol.saveDiamond.ToString(); // Elmas textime yeni değeri yazıyorum 

            }
            else
            {
                //---------------Kod gelecek
                Debug.Log("Healh Full");
            }
        }
        else
        {
            // Altın veya Elmas paneline git kodları gelecek
        }
       
    }

    public void BuyGoldSpeed()
    {
        if (MainMenucontrol.saveGold >= speedGoldValue)
        {
            if (currentSpeed < maxSpeed)
            {
                //-----------Speed Upgrade Codes
                FPSControl.speed += 0.5f; // Karakterimin hızını 0.5f artırıyorum
                PlayerPrefs.SetFloat("playerspeed", FPSControl.speed); // güncel speed değerini kaydediyorum
                Debug.Log("Player Speed +0.5 Upgrade " + FPSControl.speed);

                //---------Slider----------
                currentSpeed += 20;// Slider değerini artır 100 üzerinden hesaplanır
                PlayerPrefs.SetInt("speed", currentSpeed);// artırdığım değeri kaydediyorum
                speedSlider.value = currentSpeed;
                Debug.Log("Speed Upgrade Succesfull");// Slider değerini artır 100 üzerinden hesaplanır

                 //Money
                speedGoldValue += 5;
                speedGoldText.text = speedGoldValue.ToString();
                PlayerPrefs.SetInt("speedgold", speedGoldValue);//Güncel upgrade ücretini kaydediyorum
                speedDiamondValue += 2;
                speedDiamondText.text = speedDiamondValue.ToString();
                PlayerPrefs.SetInt("speediamond", speedDiamondValue);//Güncel upgrade ücretini kaydediyorum
                //Text
                MainMenucontrol.saveGold -= speedGoldValue; // Altın miktarımdan upgrade ücretini düşüyorum
                upGoldText.text = MainMenucontrol.saveGold.ToString(); // altın textime yeni değeri yazıyorum 

            }
            else
            {
                //---------------Kod gelecek
                Debug.Log("Speedd Full");
            }
        }
        else
        {
            // Altın veya Elmas paneline git kodları gelecek
        }
        
    }
    public void BuyDiamondSpeed()
    {
        if (MainMenucontrol.saveDiamond >= speedDiamondValue)
        {
            if (currentSpeed < maxSpeed)
            {
                //------Speed Upgrade Code
                Debug.Log("Player Speed Upgrade " + FPSControl.speed);
                FPSControl.speed += 0.5f; // Karakterimin hız değerini 0.5f artırıyorum
                PlayerPrefs.SetFloat("playerspeed", FPSControl.speed); //güncel değeri kaydediyorum
                Debug.Log("Player Speed +0.5 Upgrade " + FPSControl.speed);

                //---------Slider----------
                currentSpeed += 20;// Slider değerini artır 100 üzerinden hesaplanır
                PlayerPrefs.SetInt("speed", currentSpeed);// artırdığım değeri kaydediyorum
                speedSlider.value = currentSpeed;
                Debug.Log("Speed Upgrade Succesfull");// Slider değerini artır 100 üzerinden hesaplanır
                //Money
                speedGoldValue += 5;
                speedGoldText.text = speedGoldValue.ToString();
                PlayerPrefs.SetInt("speedgold", speedGoldValue);//Güncel upgrade ücretini kaydediyorum
                speedDiamondValue += 2;
                speedDiamondText.text = speedDiamondValue.ToString();
                PlayerPrefs.SetInt("speediamond", speedDiamondValue);//Güncel upgrade ücretini kaydediyorum
                //Text
                MainMenucontrol.saveDiamond -= speedDiamondValue; // Altın miktarımdan upgrade ücretini düşüyorum
                upDiamondText.text = MainMenucontrol.saveDiamond.ToString(); // altın textime yeni değeri yazıyorum 

            }
            else
            {
                //---------------Kod gelecek
                Debug.Log("Speedd Full");
            }
        }
        else
        {
            // Altın veya Elmas paneline git kodları gelecek
        }
       
    }
    public void BuyGoldMedkit()
    {
        if (MainMenucontrol.saveGold >= medkitGoldValue)
        {
            if (currentMedkit < maxMedkit)
            {
                //------Medkit Upgrade Code----------------
                FPSControl.medkitPlus += 10; //Medkit etkisini 10 kadar artırıyorum
                PlayerPrefs.SetInt("medkitplus", FPSControl.medkitPlus);
                Debug.Log("Meddkit + 10 Upgrade " + FPSControl.medkitPlus);

                //-----Slider
                currentMedkit += 20;// Slider değerini artır 100 üzerinden hesaplanır
                PlayerPrefs.SetInt("medkit", currentMedkit);// artırdığım değeri kaydediyorum
                medkitSlider.value = currentMedkit;
                Debug.Log("Medkit Upgrade Succesfull");// Slider değerini artır 100 üzerinden hesaplanır

                //Money
                medkitGoldValue += 5;
                medkitGoldText.text = medkitGoldValue.ToString();
                PlayerPrefs.SetInt("medkitgold", medkitGoldValue);//Güncel upgrade ücretini kaydediyorum
                medkitDiamondValue += 2;
                medkitDiamondText.text = medkitDiamondValue.ToString();
                PlayerPrefs.SetInt("medkitdiamond", medkitDiamondValue);//Güncel upgrade ücretini kaydediyorum

                //Text
                MainMenucontrol.saveGold -= medkitGoldValue; // Altın miktarımdan upgrade ücretini düşüyorum
                upGoldText.text = MainMenucontrol.saveGold.ToString(); // altın textime yeni değeri yazıyorum 

            }
            else
            {
                //---------------Kod gelecek
                Debug.Log("Speedd Full");
            }
        }
        else
        {
            // Altın veya Elmas paneline git kodları gelecek
        }
       
    }

    public void BuyDiamondMedkit()
    {
        if (MainMenucontrol.saveDiamond >= medkitDiamondValue)
        {
            if (currentMedkit < maxMedkit)
            {
                //------Medkit Upgrade Code----------------
                FPSControl.medkitPlus += 10; //Medkit etkisini 10 kadar artırıyorum
                PlayerPrefs.SetInt("medkitplus", FPSControl.medkitPlus);
                Debug.Log("Meddkit + 10 Upgrade " + FPSControl.medkitPlus);

                //-----Slider
                currentMedkit += 20;// Slider değerini artır 100 üzerinden hesaplanır
                PlayerPrefs.SetInt("medkit", currentMedkit);// artırdığım değeri kaydediyorum
                medkitSlider.value = currentMedkit;
                Debug.Log("Medkit Upgrade Succesfull");// Slider değerini artır 100 üzerinden hesaplanır
                medkitGoldValue += 5;
                medkitGoldText.text = medkitGoldValue.ToString();
                PlayerPrefs.SetInt("medkitgold", medkitGoldValue);//Güncel upgrade ücretini kaydediyorum
                medkitDiamondValue += 2;
                medkitDiamondText.text = medkitDiamondValue.ToString();
                PlayerPrefs.SetInt("medkitdiamond", medkitDiamondValue);//Güncel upgrade ücretini kaydediyorum
                //Text
                MainMenucontrol.saveDiamond -= medkitDiamondValue; // Altın miktarımdan upgrade ücretini düşüyorum
                upDiamondText.text = MainMenucontrol.saveDiamond.ToString(); // altın textime yeni değeri yazıyorum 

            }
            else
            {
                //---------------Kod gelecek
                Debug.Log("Speedd Full");
            }
        }
        else
        {
            // Altın veya Elmas paneline git kodları gelecek
        }
       
    }

    public void BuyGoldAmmobox()
    {
        if (MainMenucontrol.saveGold >= ammoboxGoldValue)
        {
            if (currentAmmobox < maxAmmobox)
            {
                //Ammo box Upgrade
                UpgradeAmmobox();

                //Slider
                currentAmmobox += 20;// Slider değerini artır 100 üzerinden hesaplanır
                PlayerPrefs.SetInt("ammobox", currentAmmobox);// artırdığım değeri kaydediyorum
                ammoboxSlider.value = currentAmmobox;
                Debug.Log("AmmoBox Upgrade Succesfull");// Slider değerini artır 100 üzerinden hesaplanır

                //Money
                ammoboxGoldValue += 5;
                ammoboxGoldText.text = ammoboxGoldValue.ToString();
                PlayerPrefs.SetInt("ammoboxgold", ammoboxGoldValue);//Güncel upgrade ücretini kaydediyorum
                ammoboxDiamondValue += 2;
                ammoboxDiamondText.text = ammoboxDiamondValue.ToString();
                PlayerPrefs.SetInt("ammoboxdiamond", ammoboxDiamondValue);//Güncel upgrade ücretini kaydediyorum

                //Text
                MainMenucontrol.saveGold -= ammoboxGoldValue; // Altın miktarımdan upgrade ücretini düşüyorum
                upGoldText.text = MainMenucontrol.saveGold.ToString(); // altın textime yeni değeri yazıyorum 

            }
            else
            {
                //---------------Kod gelecek
                Debug.Log("Ammobox Full");
            }
        }
        else
        {
            // Altın veya Elmas paneline git kodları gelecek
        }
        
    }

    public void BuyDiamondAmmobox()
    {
        if (MainMenucontrol.saveDiamond >= ammoboxDiamondValue)
        {
            if (currentAmmobox < maxAmmobox)
            {
                //Ammo box Upgrade
                UpgradeAmmobox();

                //Slider
                currentAmmobox += 20;// Slider değerini artır 100 üzerinden hesaplanır
                PlayerPrefs.SetInt("ammobox", currentAmmobox);// artırdığım değeri kaydediyorum
                ammoboxSlider.value = currentAmmobox;
                Debug.Log("AmmoBox Upgrade Succesfull");// Slider değerini artır 100 üzerinden hesaplanır

                //Money
                ammoboxGoldValue += 5;
                ammoboxGoldText.text = ammoboxGoldValue.ToString();
                PlayerPrefs.SetInt("ammoboxgold", ammoboxGoldValue);//Güncel upgrade ücretini kaydediyorum
                ammoboxDiamondValue += 2;
                ammoboxDiamondText.text = ammoboxDiamondValue.ToString();
                PlayerPrefs.SetInt("ammoboxdiamond", ammoboxDiamondValue);//Güncel upgrade ücretini kaydediyorum

                //Text
                MainMenucontrol.saveDiamond -= ammoboxDiamondValue; // Altın miktarımdan upgrade ücretini düşüyorum
                upDiamondText.text = MainMenucontrol.saveDiamond.ToString(); // altın textime yeni değeri yazıyorum 

            }
            else
            {
                //---------------Kod gelecek
                Debug.Log("Ammobox Full");
            }
        }
        else
        {
            // Altın veya Elmas paneline git kodları gelecek
        }
        
    }


    void UpgradeAmmobox()
    {
        //---Dual Shotgun
        DualShotgun.bulletCountPlus += 6; // Ammo box mermi sayısını artırıyorum
        PlayerPrefs.SetInt("ammodualshotgun", DualShotgun.bulletCountPlus);
        Debug.Log("Dual Shotgun Ammobox  + 4 Upgrade " + DualShotgun.bulletCountPlus);

        //---Dual Revolver
        DualRevControl.bulletCountPlus += 12; // Ammo box mermi sayısını artırıyorum
        PlayerPrefs.SetInt("ammodualrev", DualRevControl.bulletCountPlus);
        Debug.Log("Dual Revolver Ammobox  + 4 Upgrade " + DualRevControl.bulletCountPlus);

        //---Dual Ruger
        DualRugControl.bulletCountPlus += 12; // Ammo box mermi sayısını artırıyorum
        PlayerPrefs.SetInt("ammodualrug", DualRugControl.bulletCountPlus);
        Debug.Log("Dual Ruger Ammobox  + 4 Upgrade " + DualRugControl.bulletCountPlus);

        //---Wincester
        WincesterControl.bulletCountPlus += 6; // Ammo box mermi sayısını artırıyorum
        PlayerPrefs.SetInt("ammowincester", WincesterControl.bulletCountPlus);
        Debug.Log("Wincester Ammobox  + 4 Upgrade " + WincesterControl.bulletCountPlus);

        //---Shotgun
        ShotgunControl.bulletCountPlus += 4; // Ammo box mermi sayısını artırıyorum
        PlayerPrefs.SetInt("ammoshotgun", ShotgunControl.bulletCountPlus);
        Debug.Log("Shotgun Ammobox  + 4 Upgrade " + ShotgunControl.bulletCountPlus);

        //---Short Shotgun /Barel
        SShotgunContro.bulletCountPlus += 4; // Ammo box mermi sayısını artırıyorum
        PlayerPrefs.SetInt("ammobarel", SShotgunContro.bulletCountPlus);
        Debug.Log("Barel Ammobox  + 4 Upgrade " + SShotgunContro.bulletCountPlus);

        //---Ruger
        RugerControl.bulletCountPlus += 8; // Ammo box mermi sayısını artırıyorum
        PlayerPrefs.SetInt("ammoruger", RugerControl.bulletCountPlus);
        Debug.Log(" Ruger Ammobox  + 4 Upgrade " + RugerControl.bulletCountPlus);

        //---Revolver
        WeaponControl.bulletCountPlus += 6; // Ammo box mermi sayısını artırıyorum
        PlayerPrefs.SetInt("ammorevolver", WeaponControl.bulletCountPlus);
        Debug.Log(" Revolver Ammobox  + 4 Upgrade " + WeaponControl.bulletCountPlus);
    }

}
