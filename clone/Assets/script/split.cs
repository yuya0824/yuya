using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class split : MonoBehaviour
{
    [SerializeField]
    private GameObject character;

    // Start is called before the first frame update
    void Start()
    {
        character.transform.localScale *= new Vector2(0.8f, 0.8f);

        for(int i = 0; i < 5; i++)
        {
            Instantiate(character, new Vector3(transform.position.x, transform.position.y,transform.position.z), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
