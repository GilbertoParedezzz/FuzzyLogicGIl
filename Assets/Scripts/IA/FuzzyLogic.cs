using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuzzyLogic 
{
    float _playerHealth,_maxPlayerHealth ,_distancePlayer, _distanceHealth, _distanceAmmo, _health, _maxHealth;
    int _ammo, _maxAmmo;
    public FuzzyLogic(float playerHealth, float maxPlayerHealth, float distanceHealth, float distanceAmmo, float distancePlayer, float health, float maxHealth, int ammo, int maxAmmo) {
        _ammo = ammo;
        _playerHealth = playerHealth;
        _health = health;
        _distancePlayer = distancePlayer;
        _distanceHealth = distanceHealth;
        _distanceAmmo = distanceAmmo;
        _maxPlayerHealth = maxPlayerHealth;
        _maxAmmo = maxAmmo;
        _maxHealth = maxHealth;
    }
}
