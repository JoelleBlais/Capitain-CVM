using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyPluieDesOs : EnnemyBehaviour
{
    [SerializeField]
    private Transform _player;

    [SerializeField]
    private Transform[] _positionOs;

    [SerializeField]
    private float _rangeDeclenchePluie;

    [SerializeField]
    private float _vitesseTombeOs;

    [SerializeField]
    private GameObject _os;

    private bool pluieTombeUneFois;
    private float distanceDuJoueur;

    void Start()
    {
        pluieTombeUneFois = true;
    }

    void Update()
    {
        distanceDuJoueur = Vector2.Distance(transform.position, _player.position);

        if (distanceDuJoueur <= _rangeDeclenchePluie)
        {
            if (pluieTombeUneFois)
            {
                AttaqueDesOs();
            }
        }

    }

    void AttaqueDesOs()
    {
        for (int i = 0; i <= _positionOs.Length - 1; i++)
        {
            GameObject nouvelOs = Instantiate(_os, _positionOs[i].position, Quaternion.identity);
            nouvelOs.GetComponent<Rigidbody2D>().velocity = new Vector2(_vitesseTombeOs * Time.fixedDeltaTime, 0f);
            pluieTombeUneFois = false;
        }
        //pluieTombeUneFois = false;
    }
}
