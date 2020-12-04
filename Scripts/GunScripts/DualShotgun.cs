using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DualShotgun : MonoBehaviour
{
    public Transform bullet, firePoint, firePointSecond,firePointThrid,FirePointFourth; // mermi ve merminin cıkıs noktasını taımladım
    Transform clon, clonSecond, clonThird, clonFourth; // yaratılan mermiyi clon değişkennine atadım 
    float fireTime; // zamanı belirliyorum
    public float dualShotgunTime;//  silah atış aralığı
    public Text bulletCountText;// mermi texti
    public int bulletCount;// mermi sayısı
    public float bulletVelocity = 750f; // Mermii Hızı;
    public static int bulletCountPlus = 12;

    //----------Animations-------------------

    public Animator dualShotgun; //  animasyon
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
        if (Input.GetMouseButtonDown(0) && Time.time > fireTime && bulletCount > 0)
        {
            fireTime = Time.time + dualShotgunTime;
            //1.Shotgun
            //------1.Namlu
            clon = Instantiate(bullet, firePoint.position, firePoint.rotation);
            clon.GetComponent<Rigidbody>().AddForce(clon.forward * bulletVelocity);
            //------2.Namlu
            clonSecond = Instantiate(bullet, firePointSecond.position, firePointSecond.rotation);
            clonSecond.GetComponent<Rigidbody>().AddForce(clon.forward * bulletVelocity);
            //2.Shotgun
            //------1.Namlu
            clonThird = Instantiate(bullet, firePointThrid.position, firePointThrid.rotation);
            clonThird.GetComponent<Rigidbody>().AddForce(clon.forward * bulletVelocity);
            //------2.Namlu
            clonFourth = Instantiate(bullet, FirePointFourth.position, FirePointFourth.rotation);
            clonFourth.GetComponent<Rigidbody>().AddForce(clon.forward * bulletVelocity);
            //----- Bullet Control
            bulletCount -= 2;
            bulletCountText.text = bulletCount.ToString();

            //---------------GunSounds-------------------------------------

            FPSControl.shot();

            //-----------------Animations-------------------------------
            dualShotgun.SetTrigger("dualsgshot");
        }
    }
}
