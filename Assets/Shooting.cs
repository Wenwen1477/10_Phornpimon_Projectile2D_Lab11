using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform shootPoint;
    public float shootForce = 500f; // ลองเริ่มที่ 500 ก่อน

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
        direction.Normalize(); // ทำให้เวกเตอร์ยาว 1

        GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        rb.gravityScale = 1f;      // ให้ตกลงด้วยแรงโน้มถ่วง
        rb.drag = 1.5f;            // เพิ่มแรงต้านอากาศ
        rb.AddForce(direction * shootForce);
    }
}
