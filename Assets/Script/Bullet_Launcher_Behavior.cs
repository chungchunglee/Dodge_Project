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
            // �Ѿ� �������� �����԰� ���ÿ� bullet ���ӿ�����Ʈ�� �Ҵ��Ͽ� script ���ο��� control
            Debug.Log("target transform"+target);
            bullet.transform.LookAt(target);
            // LookAt�� ���� �ٶ󺸴� ���� ����
            spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        }
        
    }
}
