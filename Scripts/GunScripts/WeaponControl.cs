using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class WeaponControl : MonoBehaviour
{
    //----------fire--------------
    public Transform bullet, firePoint; // mermi ve merminin cıkıs noktasını taımladım
    Transform clon; // yaratılan mermiyi clon değişkennine atadım 
    float fireTime; // zamanı belirliyorum
    public float revolverTime;// revolver silah atış aralığı
    public Text bulletCountText;// mermi texti
    public int bulletCount;// mermi sayısı
    public float bulletVelocity = 750f; // Mermii Hızı;
    public static int bulletCountPlus = 16;


    //----------Animations-------------------

    public Animator pistol; // revolver animasyonu

    private void Start()
    {
        bulletCountText.text = bulletCount.ToString();
    }

    void Update()
    {
        //------AddBullet-------------
        if (FPSControl.ammoBoxControl) // fpsControl scriptindeki ammobox nesnesine değip değmediğimi kontrol ediyorum
        {
            bulletCount += bulletCountPlus; // Cephaneme mermi ekliyorum 
            FPSControl.ammoBoxControl = false; // değme durumunu false yapıyorum ki sürekli mermi eklemesin
            Debug.Log("Ammo box " + FPSControl.ammoBoxControl);
            bulletCountText.text = bulletCount.ToString(); // mermi sayımı tezte yazıyorum
        }

        //----------fire------------------------------------
        if (Input.GetMouseButtonDown(0) && Time.time > fireTime && bulletCount >0)
        {
            fireTime = Time.time + revolverTime;
            clon = Instantiate(bullet, firePoint.position, firePoint.rotation);
            clon.GetComponent<Rigidbody>().AddForce(clon.forward * bulletVelocity);
            //----- Bullet Control
            bulletCount--;
            bulletCountText.text = bulletCount.ToString();

            //---------------GunSounds-------------------------------------

            FPSControl.shot();

            //-----------------Animations-------------------------------
            pistol.SetTrigger("shotrevolver");

        }

    }

  
}
