using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class aPlayerControl : MonoBehaviour
{
    float inputX;
    float inputY;

    public Transform model;

    Animator anim;

    Vector3 stickDirecktion;

    Camera mainCamera;

    int randomGold;
    public float damp;
    [Range(0, 20)]
    public float rotSpeed;

    public GameObject rewardedAdsPanel;
    //public Text deadText;
    public GameObject deadPanel;

    int deadCount;

    void Start()
    {
        anim = GetComponent<Animator>();
        mainCamera = Camera.main;
    }


    private void LateUpdate()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");

        stickDirecktion = new Vector3(inputX, 0, inputY);

        InputMove();
        InputRotation();
    }

    void InputMove()
    {
        anim.SetFloat("walk", Vector3.ClampMagnitude(stickDirecktion, 1).magnitude, damp, Time.deltaTime * 200);
    }

     void InputRotation()
    {
        Vector3 rotOfset = mainCamera.transform.TransformDirection(stickDirecktion);
        rotOfset.y = 0;
        model.forward = Vector3.Slerp(model.forward, rotOfset, Time.deltaTime * rotSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "gold")
        {
            randomGold = Random.Range(1, 5);
            CamControl.goldCount += randomGold + 1;
            Destroy(other.gameObject);
        }

        if (other.tag == "zombie")
        {
            deadCount++;
            Debug.Log("zombi temas" + deadCount);

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
    void RewardedAdsPanel()
    {
        rewardedAdsPanel.SetActive(true);
        Time.timeScale = 0;
        
    }
    public void WatchVideo()
    {
        //Reklam kodları buraya gelecek
        DestroyAll();
        rewardedAdsPanel.SetActive(false);
        Time.timeScale = 1;
        
    }
    public void ExitRewardedPanel()
    {
        rewardedAdsPanel.SetActive(false);// buradan ölüm ekranını çağır
        DeadScene();
        Time.timeScale = 1;
    }

    public void DeadScene()
    {
        deadPanel.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    void DestroyAll()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("zombie");
        for (int i = 0; i < enemies.Length; i++)
        {
            Destroy(enemies[i]);
        }
    }
}