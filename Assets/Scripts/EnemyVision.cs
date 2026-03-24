using UnityEngine;

public class EnemyVision : MonoBehaviour
{
    public Transform player;

    public float viewDistance = 10f;   // 최대 거리
    public float viewAngle = 0.7f;     // 시야 범위 (내적 기준)

    void Update()
    {
        // 1. 방향 구하기
        Vector3 dir = (player.position - transform.position).normalized;

        // 2. 거리 구하기
        float distance = Vector3.Distance(player.position, transform.position);

        // 3. 내적 (앞 방향 비교)
        float dot = Vector3.Dot(transform.forward, dir);

        // 4. 조건 체크
        if (distance <= viewDistance && dot > viewAngle)
        {
            // 시야 안에 있음
            transform.localScale = Vector3.one * 2;
        }
        else
        {
            // 시야 밖
            transform.localScale = Vector3.one;
        }
    }
}