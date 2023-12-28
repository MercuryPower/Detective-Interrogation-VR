using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    // Start is called before the first frame update
    private int HP = 100;
    public Slider healthbar;

    // Update is called once per frame
    void Update()
    {
        healthbar.value = HP;

    }

    public void TakeDamage(int damageAmount)
    {
        HP -= damageAmount;

        if (HP <= 0)
        {
            healthbar.gameObject.SetActive(false);
        }
    }
}
