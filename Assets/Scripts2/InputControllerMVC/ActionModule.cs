using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Actions/ActionModule", fileName = "ActionModule")]
public class ActionModule : ScriptableObject
{
    private static ActionModule _instance;

    public static ActionModule Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = Resources.FindObjectsOfTypeAll<ActionModule>()[0];
            }

            return _instance;
        }

        private set
        {
            _instance = value;
        }
    }

    [System.Serializable]
    public class AbilitySet
    {
        public List<Ability> abilitySet;
    }
    [SerializeField] List<AbilitySet> _abilitySets;

    public Ability GetAbility(string abilityName, int abilitySetIndex)
    {
        AbilitySet set = abilitySetIndex < _abilitySets.Count ? _abilitySets[abilitySetIndex] : null;
        if (set != null)
        {
            Ability ability = set.abilitySet.Find((x) => x.Name == abilityName);
            if(ability != null)
            {
                return ability;
            }
            Debug.LogError("No " + abilityName + " ability in ability set " + abilitySetIndex);
            return null; 
        }
        Debug.LogError("No ability set is indexed by " + abilitySetIndex);
        return null;
    }

    public Ability GetMove(int abilitySetIndex)
    {
        return _abilitySets[abilitySetIndex].abilitySet[0];
    }

}
