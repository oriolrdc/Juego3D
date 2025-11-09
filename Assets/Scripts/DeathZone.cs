using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private PlayerController _player;
    
    void Awake()
    {
        _player = GameObject.FindWithTag("Player").GetComponent<PlayerController>();
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            _player.Death();
        }
    }
}
