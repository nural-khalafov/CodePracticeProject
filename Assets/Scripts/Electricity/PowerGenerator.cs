using UnityEngine;

namespace Scripts.Electricity
{
    public class PowerGenerator : MonoBehaviour
    {
        BoxCollider m_Collider;

        [SerializeField] private int _generatorPower;
        [SerializeField] private int _powerSupplyRadius;
        [SerializeField] private bool _generatorState;

        private void Start()
        {
            m_Collider = GetComponent<BoxCollider>();
        }

        private void Update()
        {
            m_Collider.size = new Vector3(_powerSupplyRadius, _powerSupplyRadius, _powerSupplyRadius);
        }

        private void OnTriggerEnter(Collider collider)
        {
            IElectronic electronic = collider.GetComponent<IElectronic>();
            if (_generatorState == true)
            {
                electronic?.SetPowerManagement(_generatorPower);
            }
        }
    }
}
