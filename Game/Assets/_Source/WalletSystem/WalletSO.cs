using UnityEngine;

namespace WalletSystem
{
    [CreateAssetMenu(fileName = "WalletSO", menuName = "SO/Wallet")]
    public class WalletSO : ScriptableObject
    {
        [SerializeField] private int value;

        public int Value => value;
        public int Kroken => 0;
        public int Dobbner => 0;
        public int Ukht => 0;
    }
}