using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShotgunControl : MonoBehaviour
{
    public Transform bullet, firePoint, firePointSecond; // mermi ve merminin cıkıs noktasını taımladım
    Transform clon; // yaratılan mermiyi clon değişkennine atadım 
    Transform clonSecond; // yaratılan mermiyi clon değişkennine atadım 
    float fireTime; // zamanı belirliyorum
    public float shotgunTime;//  silah atış aralığı
    public Text bulletCountText;// mermi texti
    public int bulletCount;// mermi sayısı
    public float bulletVelocity = 750f; // Mermii Hızı;
    public static int bulletCountPlus = 8;


    //----------Animations-------------------

    public Animator shotgun; //  animasyon
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
        if (Input.GetMouseButtonDown(0) && Time.time > fireTime && bulletCount > 0)
        {
            fireTime = Time.time + shotgunTime;
            //------1.Namlu---------
            clon = Instantiate(bullet, firePoint.position, firePoint.rotation);
            clon.GetComponent<Rigidbody>().AddForce(clon.forward * bulletVelocity);
            //------2.Namlu
            clonSecond = Instantiate(bullet, firePointSecond.position, firePointSecond.rotation);
            clonSecond.GetComponent<Rigidbody>().AddForce(clon.forward * bulletVelocity);
            //----- Bullet Control
            bulletCount--;
            bulletCountText.text = bulletCount.ToString();

            //---------------GunSounds-------------------------------------

            FPSControl.ShotgunShot();

            //-----------------Animations-------------------------------
            shotgun.SetTrigger("shotgunshot");

        }
    }
}
