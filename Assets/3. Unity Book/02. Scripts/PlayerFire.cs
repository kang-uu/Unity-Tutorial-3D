using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletFactory;
    public GameObject firePosition;

    public int poolSize = 10;
    public GameObject[] bulletObjectPool;

    void Start()
    {
        bulletObjectPool = new GameObject[poolSize];

        for (int i = 0; i < poolSize; i++)
        {
            GameObject bullet = Instantiate(bulletFactory);
            bulletObjectPool[i] = bullet;
            bullet.SetActive(false);
        }
    }
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            for (int i = 0; i < poolSize; i++)
            {
                GameObject bullet = bulletObjectPool[i];
                
                if (!bullet.activeSelf) // 선택한 총알 오브젝트가 비활성화 상태인지 확인
                {
                    bullet.SetActive(true); // 총알을 사용하기 위해 활성화
                    bullet.transform.position = firePosition.transform.position; // 발사 위치 조정

                    break; // 반복문 종료
                }
            }
        }
    }
}