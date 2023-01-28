using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text _playerName, _attackLvl, _magicLvl, _smithingLvl, _miningLvl;
  //  [SerializeField] private Player _player; 
    // Start is called before the first frame update
    void Start()
    {
      //  _playerName.text = "Name: " + _player.playerName;
      //  _attackLvl.text = "AttackLvl: " + _player.attackLevel;
      //  _magicLvl.text = "MagicLvl: " + _player.magicLevel;
     //   _smithingLvl.text = "SmithingLvl " + _player.smithingLevel;
      //  _miningLvl.text = "MiningLvl: " + _player.miningLevel;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
