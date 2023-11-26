using Chia_Client_API.WalletAPI_NS;
using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.Wallet_NS;

namespace ChiaBalance
{
    internal class Program
    {
        private static Wallet_RPC_Client Wallet = new Wallet_RPC_Client(reportResponseErrors: false);

        public static void Main()
        {
            WalletID_RPC walletID_RPC = new WalletID_RPC(1);
            GetWalletBalance_Response response = Wallet.GetWalletBalance_Sync(walletID_RPC);
            Console.WriteLine(response.wallet_balance.confirmed_wallet_balance_in_xch);
            Console.ReadKey();
        }
    }
}