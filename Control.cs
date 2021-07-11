using UnityEngine;

public class Control : MonoBehaviour
{
    public float Movespeed = 1.0f;
    private Animator anim = null;

    private void Start()
    {
        anim = this.GetComponent<Animator>();
    }
    private void Update()
    {
        float horz = Input.GetAxis("Horizontal");
        anim.SetFloat("horz", horz);
        this.transform.Translate(Vector3.right * horz * Movespeed * Time.deltaTime);
    }
}
