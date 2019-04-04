using UnityEngine;

namespace TestDrivenDevelopment
{

    public class TDDComponent : MonoBehaviour
    {

        #region Field

        [SerializeField]
        private TDDObject _TDDObject;

        #endregion // Field End.

        void Start()
        {
            _TDDObject.Initialize();
        }

        void OnDestroy()
        {
            _TDDObject.Finalize();
        }

        void Update()
        {
            _TDDObject.Update();
        }
    }

}