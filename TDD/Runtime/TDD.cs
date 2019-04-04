using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TestDrivenDevelopment {

    [Serializable]
    [CreateAssetMenu(menuName = "ScriptableObject/TestDrivenDevelopment/TDDObject")]
    public class TDDObject : ScriptableObject    
    {
        public virtual void Initialize() { Debug.Log("[ TDD ] : Initialize"); }
        public virtual void Finalize() { Debug.Log("[ TDD ] : Finalize"); }
        public virtual void Update() { Debug.Log("[ TDD ] : Update"); }

        public static TDDObject Create()
        {
            return ScriptableObject.CreateInstance<TDDObject>();
        }

        public static TDDObject Load(string key)
        {
            return Resources.Load<TDDObject>("TDDObject/" + key);
        }

        public static TDDObject Instantiate(string key)
        {
            return UnityEngine.Object.Instantiate<TDDObject>(Load(key));
        }
    }

}