using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Launcher_Behavior : MonoBehaviour
{
    public GameObject bulletPrefab;
    
    public float spawnRateMin = 0.5f;
    public float spawnRateMax = 3.0f;

    private Transform target;
    private float spawnRate;
    private float timeAfterSpawn;
    
    void Start()
    {
        timeAfterSpawn = 0f;
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        target = FindObjectOfType<Player_Controller>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawn += Time.deltaTime;
        if(timeAfterSpawn >= spawnRate)
        {
            timeAfterSpawn = 0;
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            // 총알 프리팹을 생성함과 동시에 bullet 게임오브젝트에 할당하여 script 내부에서 control
            Debug.Log("target transform"+target);
            bullet.transform.LookAt(target);
            // LookAt을 통해 바라보는 방향 설정
            spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        }
        
    }
}
