using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform shootPoint;
    public float shootForce = 500f; // �ͧ�������� 500 ��͹

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mousePosition - shootPoint.position);
        direction.Normalize(); // ������ǡ������� 1

        GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        rb.gravityScale = 1f;      // ��鵡ŧ�����ç�����ǧ
        rb.drag = 1.5f;            // �����ç��ҹ�ҡ��
        rb.AddForce(direction * shootForce);
    }
}
