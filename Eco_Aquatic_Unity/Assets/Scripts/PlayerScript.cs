using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{

    public GameObject bubble;
    public float delayTime;
    bool canShoot = true;
    
    //shooting
    void Update()
    {
     
        if (canShoot && Input.GetMouseButton(1))
        {
            canShoot = false;
            Instantiate(bubble, transform.position, transform.rotation);
            StartCoroutine(NoFire());
        }
    }

    IEnumerator NoFire()
    {
        yield return new WaitForSeconds(delayTime);
        canShoot = true;
    }
}