using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using Color = UnityEngine.Color;

public class bullet : MonoBehaviour 
 {

    public float StartTime=0;
    public float DestroyTime=2;
    private GameObject bulletClone ;

    public float bulletSpeed = 100;
     //public Rigidbody bullet;
    public GameObject BulletPF;
    private List<GameObject> listObj = new List <GameObject>();
     
     


     void Fire()
     {

        bulletClone = Instantiate(BulletPF, transform.position, transform.rotation);
        bulletClone.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;

       // var color_obj = bulletClone.GetComponent<Color>();
        var material_obj = bulletClone.GetComponent<Material>();

        listObj.Add(bulletClone);

        // Debug.Log(color_obj);
        Debug.Log(material_obj);


        var color1 = (int)Random.Range(0, 255);
        var color2 = (int)Random.Range(0, 255);
        var color3 = (int)Random.Range(0, 255);

      //  df = new UnityEngine.Color(color1 / 255.0f, color2 / 255.0f, color3 / 255.0f);

        
        Destroy(bulletClone, 125.5f);



    }
 

    void make10units()
    {
        Debug.Log(listObj.Count);
        // for (int i = 0; i < listObj.Count; i++)

        int i = 1;
        foreach (var obj in listObj )
        {
            i++;
            Destroy(obj, i);

        }



    }


     void Update () 
     {


        if (Input.GetButtonDown("Fire1"))
        {
            make10units();
            
        }
        if (Input.GetButtonDown("Fire2"))
        {
            Fire();
            
        }
    }
}