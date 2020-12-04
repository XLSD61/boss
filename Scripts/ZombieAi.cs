using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class ZombieAi : MonoBehaviour
{
    public  float speed;
    public static float distancee;
    public bool idle, running, attack;
    public BoxCollider colider;
    GameObject player;
    Vector3 poz;

    NavMeshAgent agent;

    Animator zombiAnimator;

    int zombieHealth = 100; // zombilerin canı
    public int initHealth; // baslangıc canı
    public Image HealthBar; // zombi can barı
    int revolverDamage = 50; // revolver silah hasarı

    public Vector3 pozbir;
    public GameObject gold;
    public GameObject diamond;
    public GameObject ammoBox;
    public GameObject medkid;


    int rnd;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        zombiAnimator = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");

        initHealth = zombieHealth;

    }

    
    void Update()
    {
        poz = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z); //Look at komutu için

        HealthBar.fillAmount = (float)zombieHealth / (float)initHealth;

        // Mesafe ölcümü
        distancee = Vector3.Distance(transform.position, player.transform.position); // zombinin playere mesafesi
        
        //Debug.DrawRay(transform.position, Vector3.up, Color.red);
        //if(distancee >= 101)
        //{
        //    idle = true;
        //    running = false;
        //    attack = false;
        //    zombiAnimator.SetTrigger("idle");
        // }
        if (distancee <= 100 && distancee > 3.0f)
        {
            transform.LookAt(poz);// zombinin playere bakması için
            running = true;
            zombiAnimator.SetTrigger("run");
            agent.destination = player.transform.position;
            //transform.position =  Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            attack = false;
            
            
        }
        if(distancee <= 3.0f)
        {
            transform.LookAt(poz);// zombinin playere bakması için 
            
            attack = true;
            zombiAnimator.SetTrigger("attack");         
            running = false;
            

        }
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "bullet") // zombiye mermi değdğinde
        {
            zombieHealth -= revolverDamage; // zombi canından silah hasarı kadar düş
            Destroy(col.gameObject); // mermiyi yok et

            if (zombieHealth == 0) // zombinin canı 0 ve daha az olursa
            {
                rnd = Random.Range(0, 101);
                Debug.Log("random sayi " + rnd);
                pozbir = new Vector3(transform.position.x, player.transform.position.y + 0.5f, transform.position.z); // zombinin öldüğü konumu poz değişkenni içine kaydediyorum               
                CamControl.score++; // score artırma
                colider.enabled = false;
                zombiAnimator.SetTrigger("dying");// zombi ölüm animasyou oynatıyoruum
                ObjeSpawn();
                //Instantiate(gold, pozbir, Quaternion.identity); // zombinin öldüğü konum da altın klonlıyorum
                Destroy(gameObject, 1.5f); ; // zombiyi yok et
                

            }
        }
    }

    public void ObjeSpawn()
    {
        if(rnd < 35)
        {
            Instantiate(gold, pozbir, Quaternion.identity); // zombinin öldüğü konum da gold klonlıyorum
            Debug.Log("gold");
        }
        
        else if (rnd > 35 && rnd < 40)
        {
            Instantiate(ammoBox, pozbir, Quaternion.identity); // zombinin öldüğü konum da ammobox klonlıyorum
            Debug.Log("ammo");
        }
        else if (rnd > 40 && rnd < 50)
        {
            Instantiate(gold, pozbir, Quaternion.identity); // zombinin öldüğü konum da gold klonlıyorum
            Debug.Log("gold");
        }
        else if (rnd > 50 && rnd < 55)
        {
            Instantiate(ammoBox, pozbir, Quaternion.identity); // zombinin öldüğü konum da ammobox klonlıyorum
            Debug.Log("ammo");
        }
        else if (rnd > 55 && rnd <= 60)
        {
            Instantiate(diamond, pozbir, Quaternion.identity); // zombinin öldüğü konum da elmas klonlıyorum
            Debug.Log("diamond");
        }
        else if (rnd > 60 && rnd < 70)
        {
            Instantiate(gold, pozbir, Quaternion.identity); // zombinin öldüğü konum da gold klonlıyorum
            Debug.Log("gold");
        }
        else if (rnd >70 && rnd < 75)
        {
            Instantiate(medkid, pozbir, Quaternion.identity); // zombinin öldüğü konum da medkit klonlıyorum
            Debug.Log("medkit");
        }
        else if (rnd > 75 && rnd < 100)
        {
            Instantiate(gold, pozbir, Quaternion.identity); // zombinin öldüğü konum da gold klonlıyorum
            Debug.Log("gold");
        }

    }
}
