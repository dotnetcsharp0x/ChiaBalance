using Chia_Client_API.WalletAPI_NS;
using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.Wallet_NS;
using Chia_Client_API.FullNodeAPI_NS;

namespace ChiaBalance
{
    internal class Program
    {
        private static Wallet_RPC_Client Wallet = new Wallet_RPC_Client(reportResponseErrors: false);
        private static FullNode_RPC_Client node;
        
        

        public static void Main()
        {
            foreach (var item in Wallet.GetWallets_Sync().wallets)
            {
                WalletID_RPC walletID_RPC = new WalletID_RPC(item.id);
                GetWalletBalance_Response response = Wallet.GetWalletBalance_Sync(walletID_RPC);
                Console.WriteLine(response.wallet_balance.confirmed_wallet_balance_in_xch);
                var a = Wallet.GetWallets_Sync();
            }
            Console.ReadKey();
        }
    }
}