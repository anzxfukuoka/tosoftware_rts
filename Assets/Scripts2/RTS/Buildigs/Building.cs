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
    [SerializeField] private int level = 0;
    [SerializeField] UpgradeTypes _upgradeType;
    private static PlayerSpaceShip _player;

    public static PlayerSpaceShip playerInstance
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

    private void Awake()
    {
        switch (_upgradeType)
        {
            
            case (UpgradeTypes.damagePrimaryWeapon):

                playerInstance.primaryWeaponUnlocked = true;


                break;
            case (UpgradeTypes.damageSecondaryWeapon):

                    playerInstance.secondaryWeaponUnlocked = true;

                break;
            default:
                break;

        }
    }

    public void Upgrade()
    {
        level++;
        switch (_upgradeType)
        {
            case (UpgradeTypes.speed):
                playerInstance.moveSpeed += level / 2;
                break;
            case (UpgradeTypes.rotSpeed):
                playerInstance.rotateSpeed += level / 2;
                break;
            case (UpgradeTypes.damagePrimaryWeapon):

                playerInstance.weapon1.damagePower += level;
                
                break;
            case (UpgradeTypes.damageSecondaryWeapon):

                    playerInstance.weapon2.damagePower += level;
                break;
            default:
                break;
            
        }
    }
}
