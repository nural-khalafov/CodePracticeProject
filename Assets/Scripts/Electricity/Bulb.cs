using UnityEngine;

namespace Scripts.Electricity
{
    public class Bulb : MonoBehaviour, IElectronic
    {
        Light m_light;

        public int requiredPower = 1;
        public bool state;

        public bool State => state;
        public int RequiredPower => requiredPower;


        private void Start()
        {
            m_light = GetComponent<Light>();
        }

        private void OnTriggerExit(Collider collider)
        {

            state = false;
            m_light.enabled = false;
        }

        public void SetPowerManagement(int power)
        {
            if (power >= requiredPower)
            {
                state = true;
                m_light.enabled = true;
            }
            else
            {
                state = false;
                m_light.enabled = false;
            }
        }
    }
}
