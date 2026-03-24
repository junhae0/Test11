using UnityEngine;

public class Orbit : MonoBehaviour
{
    public Transform center;   // 중심 (태양 or 지구)
    public float radius = 5f;  // 거리
    public float speed = 1f;   // 회전 속도

    private float angle = 0f;

    void Update()
    {
        // 각도 증가 (시간 기반)
        angle += speed * Time.deltaTime;

        // x, z 좌표 계산 (원 운동)
        float x = Mathf.Cos(angle) * radius;
        float z = Mathf.Sin(angle) * radius;

        // 중심 기준 위치 설정
        transform.position = center.position + new Vector3(x, 0, z);
    }
}