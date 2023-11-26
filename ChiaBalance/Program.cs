using Chia_Client_API.WalletAPI_NS;
using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.Wallet_NS;
using Chia_Client_API.FullNodeAPI_NS;
using CHIA_RPC.FullNode_NS;

namespace ChiaBalance
{
    internal class Program
    {
        private static Wallet_RPC_Client Wallet = new Wallet_RPC_Client(reportResponseErrors: false);
        private static FullNode_RPC_Client node;
        
        

        public static void Main()
        {
            node = new FullNode_RPC_Client(reportResponseErrors: false);
            foreach (var item in Wallet.GetWallets_Sync().wallets)
            {
                WalletID_RPC walletID_RPC = new WalletID_RPC(item.id);
                GetWalletBalance_Response response = Wallet.GetWalletBalance_Sync(walletID_RPC);
                Console.WriteLine(response.wallet_balance.confirmed_wallet_balance_in_xch);
            }
            var a = node.GetNetworkSpace_Sync(new GetNetworkSpace_RPC("0xf432a8f256f9da0cb695f29592140aeb98706c9b8a73881c52d152e9ba3cc769", "0x11419f3f0c741044ebf0ac4cb933b167a76617bd26484b3833056e1f3314c63e"));
            Console.WriteLine(a.space_eb);
            Console.ReadKey();
        }
    }
}