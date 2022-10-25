using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_ATM
{
    public class AtmModel
    {
        private string accNum;
        private string accType;
        private string accName;
        private string accPin;

        public void setAccNum(string accNum)
        {
            this.accNum = accNum;
        }
        public string getAccNum()
        {
            return accNum;
        }

        public void setAccType(string accType)
        {
            this.accType = accType;
        }
        public string getAccType()
        {
            return accType;
        }

        public void setAccPin(string accPin)
        {
            this.accPin = accPin;
        }
        public string getAccPin()
        {
            return accPin;
        }
    }
}
