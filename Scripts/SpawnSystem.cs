using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
    public  GameObject[] Zombies; // zombileri array haline getirdim
    public Transform[] Spawner; // spawn noktalarını array haline getirdim
    public Transform player; // playeri tanıttım
    float playerDistanceSpawn; // player ile spawn noktlaları arasındaki mesafeiy ölcmek icin

    public float spawntime;
    public float spawnDelay;
    public int zombiCount;
    public int distanceMin;
    public int distanceMax;
    
   
    void Start()
    {
        //if (playerDistanceSpawn >= 20 && playerDistanceSpawn <= 50)
        //{
            
            InvokeRepeating("Spawn", spawntime, spawnDelay);
        //}
       
    }

    
    void Update()
    {
        Distance();
    
    }

    void Distance() // zombi ile player arası mesafe ölcüyorum
    {
        for (int i = 0; i < Spawner.Length; i++)
        {
            playerDistanceSpawn = Vector3.Distance(player.position,Spawner[i].position );
        }      
    }

    void Spawn() // zombi spawn etme islemimi yapıyorum
    {
        if (playerDistanceSpawn >= distanceMin && playerDistanceSpawn <= distanceMax)
        {
            for (int i = 0; i <= zombiCount; i++)

            {
                Instantiate(Zombies[Random.Range(0, Zombies.Length)], Spawner[Random.Range(0, Spawner.Length)].position, Quaternion.identity);
            }
           
        }
        
    }
    
}
