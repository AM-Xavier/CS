using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BankAccount {
    internal class System {
        public int AccountNumber { get; private set; }
        public string Name { get; private set; }
        public bool InitialDeposit { get; private set; }
        public double IDValue { get; private set; }
        public double Deposit { get; private set; }
        public double Withdraw { get; private set; }

        public System(int accountNumber, string name, bool initialDeposit, double iDValue) {
            AccountNumber = accountNumber;
            Name = name;
            InitialDeposit = initialDeposit;
            IDValue = iDValue;
        }
        public System(int accountNumber, string name, bool initialDeposit) {
            AccountNumber = accountNumber;
            Name = name;
            InitialDeposit = initialDeposit;
        }

        public double DepositValue(double deposit) {
            return Deposit += deposit;
        }
        public double WithdrawValue(double withdraw) {
            return Withdraw += withdraw + 5.0;
        }

        public override string ToString() {
            if(InitialDeposit == true) {
                return "Account "
                + AccountNumber
                + ", Holder: "
                + Name
                + ", Balance: $ "
                + (IDValue + Deposit - Withdraw).ToString("F2", CultureInfo.InvariantCulture);
            }
            else {
                return "Account "
                + AccountNumber
                + ", Holder: "
                + Name
                + ", Balance: $ "
                + (Deposit - Withdraw).ToString("F2", CultureInfo.InvariantCulture);
            }
        }
    }
}