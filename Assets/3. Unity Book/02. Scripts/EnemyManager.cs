using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public int poolSize = 10;

    public GameObject[] enemyObjectPool;
    public Transform[] spawnPoints;
    
    public GameObject enemyFactory;
    
    private float currentTime; // 타이머
    private float minTime = 1;
    private float maxTime = 5;
    public float createTime = 1f; // 생성 주기
    
    void Start()
    {
        createTime = Random.Range(minTime, maxTime);
        
        enemyObjectPool =  new GameObject[poolSize];

        for (int i = 0; i < poolSize; i++)
        {
            GameObject enemy = Instantiate(enemyFactory);

            enemyObjectPool[i] = enemy;
            enemy.SetActive(false);
        }
    }

    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > createTime) // 랜덤한 시간이 될 때 마다 랜덤한 위치에 Enemy 생성
        {
            currentTime = 0f;
            createTime = Random.Range(minTime, maxTime);

            for (int i = 0; i < poolSize; i++)
            {
                GameObject enemy = enemyObjectPool[i];
                if (!enemy.activeSelf)
                {
                    int ranIndex = Random.Range(0, spawnPoints.Length);
                    Transform spawnPoint = spawnPoints[ranIndex];
                    
                    enemy.transform.position = spawnPoint.position;
                    enemy.SetActive(true);

                    break;
                }
            }
            
        }
    }
}