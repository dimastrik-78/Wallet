using UnityEngine;
using UnityEngine.UI;

namespace Core
{
    public class CanvasUI : MonoBehaviour
    {
        [SerializeField] private Text wallet;

        public void ValueWallet(int value)
        {
            wallet.text = $"Кошелёк: {value}";
        }
    }
}