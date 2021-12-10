using UnityEngine;

public class Gun : MonoBehaviour {

    //Weapon damage and range
    public float damage = 10f;
    public float range = 100f;

    [SerializeField] private AudioSource _audiosource;
    public Camera fpsCam;
    public ParticleSystem muzzleFlash;

    // Update is called once per frame
    void Update() {

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();

        }
        
    }

    void Shoot ()
    {
        muzzleFlash.Play();
        shootingsound();

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }

    void shootingsound ()
    {
        _audiosource.PlayOneShot(_audiosource.clip);
    }
}
