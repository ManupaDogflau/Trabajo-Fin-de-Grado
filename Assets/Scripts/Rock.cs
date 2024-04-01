using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{

   [SerializeField] private Transform _RespawnPoint;
   [SerializeField] private int _correctId;
   [SerializeField] private int _incorrectId;
   [SerializeField] private GameObject _soldier;
   [SerializeField] private GameObject _quest;
   [SerializeField] private RockEliminationController _controller;
   [SerializeField] private GameObject _somkeBomb;
   [SerializeField] private GameObject _bomb;
    [SerializeField] private AudioClip _explosion;
    [SerializeField] private AudioClip _hammer;

    private void OnEnable()
    {
        _quest.SetActive(false);
    }
    public void CorrectItem(ItemCheckedEvent itemCheckedEvent)
   {
        if (itemCheckedEvent.element == _correctId)
        {
            Instantiate(_somkeBomb, transform.position, Quaternion.identity);
            SoundEmitter.Instance().PlaySFX(_hammer);
            gameObject.SetActive(false);
        }
        
    }

    public void IncorrectItem(ItemCheckedEvent itemCheckedEvent)
    {
        if (itemCheckedEvent.element == _incorrectId)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            player.transform.position = _RespawnPoint.position;
            GameObject objecto =Instantiate(_soldier, new Vector3(transform.position.x,0,transform.position.z),Quaternion.identity);
            Instantiate(_bomb, transform.position, Quaternion.identity);
            objecto.transform.LookAt(_RespawnPoint.position);
            SoundEmitter.Instance().PlaySFX(_explosion);
            gameObject.SetActive(false);
            _controller.Activate();
        }
            
    }
}
