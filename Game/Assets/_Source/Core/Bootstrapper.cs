using UnityEngine;
using WalletSystem;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private CanvasUI canvasUI;
        [SerializeField] private WalletSO walletSO;

        private void Awake()
        {
            canvasUI.ValueWallet(walletSO.Value);
        }
    }
}