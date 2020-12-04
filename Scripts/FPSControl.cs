using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSControl : MonoBehaviour
{
    //----------Karakter Kontolü--------------
    CharacterController controller;
    public static float speed = 5.0f; //Player Speeed *********************Upgrade******************
    public int deadTimer = 2; // Ölüm sayacı


    //-----------Camera Kontrolü-----------
    [Range(50, 500)]
    public float sens;
    public float xRotation = 0f;


    //----------Jump and Gravity--------
    private Vector3 velocity;
    private float gravity = -9.81f;
    public Transform groundChecker;
    public float groundCheckerRadius;
    public LayerMask obstacleLayer;
    private bool isGround;
    public float jumpHeight = 0.1f;
    public float gravityDivide = 10f;


    //---------- panel Kontrol------------
    public GameObject rewardedAdsPanel;
    //public Text deadText;
    public GameObject deadPanel;
    public GameObject crosshair, mmimage; // cross ve ve minimap
    public GameObject healtImg, bulletImg; // health bar ve bulletcount

    //----------HealthBar------------------
    public static int playerHealth = 100; // player canı ***************Upgrade***********************
    public int playerInitHealth; // baslangıc canı
    public Image playerHealthBar; // zombi can barı
    public int zombieDamage = 50; // Zombi hasarı
    public static int medkitPlus = 20; // Medkit   ******************Upgrade***************************
    public Text healthText;

    //-----AmmoBox----------
    public static bool ammoBoxControl = false;


    int deadCount; // ölüm sayısını değişkende tutma
    int random; // random değer üretimi

    //--------Sounds---------------

     static AudioSource[] sounds;



    private void Awake()
    {

        controller = GetComponent<CharacterController>();

        sounds = GetComponents<AudioSource>();

        //--------Cursor(Mouse imleci)
        Cursor.visible = false; //imleci kapatıyorum
        Cursor.lockState = CursorLockMode.Locked;//imleci ortaya hedefliyor
    }
    private void Start()
    {
        playerInitHealth = playerHealth;
        healthText.text = playerHealth.ToString();

        //speed = PlayerPrefs.GetFloat("playerspeed", 5.0f);
        Debug.Log("Player Health " + playerHealth);
        Debug.Log("Player Speed " + speed);
    }

    private void Update()
    {
        // HealthBar
        playerHealthBar.fillAmount = (float)playerHealth / (float)playerInitHealth;

        // Check chracter is grounded

        isGround = Physics.CheckSphere(groundChecker.position, groundCheckerRadius, obstacleLayer);


        //----------Karakter Kontolü--------------

        Vector3 moveInputs = Input.GetAxis("Horizontal") * transform.right + Input.GetAxis("Vertical") * transform.forward;
        Vector3 moveVelocity = moveInputs * Time.deltaTime * speed;

        controller.Move(moveVelocity);


        //-----------Camera/Mouse Kontrolü-----------

        transform.Rotate(0, Input.GetAxis("Mouse X") * Time.deltaTime * sens,0);
        xRotation -= Input.GetAxis("Mouse Y") * Time.deltaTime * sens;

        xRotation = Mathf.Clamp(xRotation, -90, 90);

        Camera.main.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);



        //----------Jump and Gravity--------

        if (!isGround)
        {
            velocity.y += gravity * Time.deltaTime / gravityDivide;
        }
        else
        {
            velocity.y = -0.05f;
        }

        if(Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f *gravity / gravityDivide * Time.deltaTime *10);
        }

        controller.Move(velocity);
    }

    //----------- Player Temas Kontrol------------
    private void OnTriggerEnter(Collider other)
    {
        //---------- Player Gold temas-------------------
        if (other.tag == "gold")
        {
            random = Random.Range(1, 5);
            CamControl.goldCount += random + 1;
            sounds[0].Play(); // altın sesi
            Destroy(other.gameObject);
        }

        //--------Player Diamond Control--------
        if(other.tag == "diamond")
        {
            random = Random.Range(1, 3);
            CamControl.diamondCount += random + 1;
            sounds[2].Play(); // elmas  sesi
            Destroy(other.gameObject);
        }

        //----------- Player Medkit Control------------
        if(other.tag == "medkit")
        {
            playerHealth += medkitPlus;
            sounds[3].Play(); // medkit  sesi
            healthText.text = playerHealth.ToString();
            Destroy(other.gameObject);
        }

        //----------- Player Ammobox Control------------
        if (other.tag == "ammobox")
        {
            ammoBoxControl = true;
            Debug.Log(ammoBoxControl+ "Ammo");
            sounds[4].Play(); // ammobox  sesi
            Destroy(other.gameObject);
        }

        //-------- Player zombi temas----------------

        if (other.tag == "zombie")
        {
            deadTimer--;
            if(deadTimer == 0)
            {
                playerHealth -= zombieDamage;
                healthText.text = playerHealth.ToString();
                deadTimer = 2;

            }
            if (playerHealth <= 0)
            {
                deadCount++; // ölüm sayacı
                Debug.Log("player dead" + deadCount);

                if (deadCount == 1)
                {
                    RewardedAdsPanel();
                }

                if (deadCount == 2)
                {
                    DeadScene();
                }
            }
        }
      
    }

    // ----------------Reklam Paneli--------------
    void RewardedAdsPanel()
    {
        rewardedAdsPanel.SetActive(true);
        Time.timeScale = 0;

        //-------UI Kontrol---------

        crosshair.SetActive(false);//crosshairimi kapatıyorum
        mmimage.SetActive(false);// minimapı kapatıyorum
        healtImg.SetActive(false);// Health barı kapatıyorum
        bulletImg.SetActive(false); // bullet göstergesini kapatıyorum;

        //----Curser İmlec acma-------

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

    }

    // -----------Reklam izle butonu--------------
    public void WatchVideo()
    {
        //Reklam kodları buraya gelecek
        DestroyAll();// Zombileri yok ediyorum
        playerHealth = playerInitHealth; // Can değerimi baslangıc canıma eşitliyorum
        //****************************Mermi Ekle****************************************
        //-------UI Kontrol---------

        crosshair.SetActive(true);//crosshairimi acıyorum
        mmimage.SetActive(true);// minimapı acıyorum
        healtImg.SetActive(true);// Health barı kapatıyorum
        bulletImg.SetActive(true); // bullet göstergesini kapatıyorum;

        //----Curser İmlec kapatma-------

        Cursor.visible = false; //imleci kapatıyorum
        Cursor.lockState = CursorLockMode.Locked;//imleci ortaya hedefliyor
        //--------Panel Kontrol
        rewardedAdsPanel.SetActive(false); // reklam panelini kapatıyorum
        Time.timeScale = 1; // oyunu başlatıyorum

    }
    // Reklam butonuna tıklanınca zombileri yok etme fonksiyonu--------------

    void DestroyAll()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("zombie");
        for (int i = 0; i < enemies.Length; i++)
        {
            Destroy(enemies[i]);
        }
    }

    //------- Reklam paneli kaptma butonu---------------
    public void ExitRewardedPanel()
    {
        rewardedAdsPanel.SetActive(false);// buradan ölüm ekranını çağır
        DeadScene();
        Time.timeScale = 1;
    }

     //----------- Ölüm paneli--------------------
    public void DeadScene()
    {
        deadPanel.gameObject.SetActive(true); // ölüm panelini acıyorum
        Time.timeScale = 0;// zamanı durduruyorum
        PlayerPrefs.SetInt("gold", CamControl.goldCount);// toplanan altını kaydediyorum
        PlayerPrefs.SetInt("diamond", CamControl.diamondCount);// toplanan elması kaydediyorum

        crosshair.SetActive(false);//crosshairimi kapatıyorum
        mmimage.SetActive(false);// minimapı kapatıyorum
        healtImg.SetActive(false);// Health barı kapatıyorum
        bulletImg.SetActive(false); // bullet göstergesini kapatıyorum;

        //----Curser İmlec acma-------

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        //--------Player Health
        playerHealth = playerInitHealth; // ölümce can değerimi baslangıc can değerine eşitliyorum


    }
    // Soundds
    public  static void shot()
    {
        sounds[1].Play();
    }
    public static void WincesterShot()
    {
        sounds[5].Play();
    }
    public static void ShotgunShot()
    {
        sounds[6].Play();
    }





}
