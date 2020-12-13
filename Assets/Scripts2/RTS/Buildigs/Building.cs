using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    private enum UpgradeTypes
    {
        none,
        speed,
        rotSpeed,
        damagePrimaryWeapon,
        damageSecondaryWeapon
    }
    [SerializeField] private int level = 1;
    [SerializeField] UpgradeTypes _upgradeType;
    private static PlayerSpaceShip _player;

    private static PlayerSpaceShip _playerInstance
    {
        get
        {
            if(_player == null)
            {
                _player = FindObjectOfType<PlayerSpaceShip>();
            }
            return _player;
        }
        set
        {
            _player = value;
        }
    }

    public void Upgrade()
    {
        level++;
        switch (_upgradeType)
        {
            case (UpgradeTypes.speed):
                _playerInstance.moveSpeed += level / 2;
                break;
            case (UpgradeTypes.rotSpeed):
                _playerInstance.rotateSpeed += level / 2;
                break;
            case (UpgradeTypes.damagePrimaryWeapon):
                _playerInstance.weapon1.damagePower += level;
                break;
            case (UpgradeTypes.damageSecondaryWeapon):
                _playerInstance.weapon2.damagePower += level;
                break;
            default:
                break;
            
        }
    }
}
