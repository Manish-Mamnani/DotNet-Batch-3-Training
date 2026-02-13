using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBank
{
    public class CreditRiskProcessor
    {
        public bool validateCustomerDetails(int age,string employmentType,double monthlyIncome,double dues,int creditScore,int defualts)
        {
            if(age<21 || age > 65)
            {
                throw new InvalidCreditDataException("Invalid Age");
            }
            if(employmentType != "Salaried" && employmentType != "Self-Employed")
            {
                throw new InvalidCreditDataException("Invalid employment type");
            }
            if (monthlyIncome < 20000)
            {
                throw new InvalidCreditDataException("Invalid monthly income");
            }
            if(dues < 0)
            {
                throw new InvalidCreditDataException("Invalid credit dues");
            }
            if(creditScore <= 300 || creditScore >= 900)
            {
                throw new InvalidCreditDataException("Invalid credit score");
            }
            if(defualts < 0)
            {
                throw new InvalidCreditDataException("Invalid default count");
            }

            return true;
        }

        public int calculateCreditLimit(double monthlyIncome, double dues, int creditScore, int defaults)
        {
            double debtRatio = dues / (monthlyIncome * 12);
            int creditLimit = 0;

            if(creditScore < 600 || defaults >=3 || debtRatio > 0.4)
            {
                creditLimit = 50000;
            }
            if((creditScore > 600 && creditScore < 749) || (defaults == 1 || defaults == 2))
            {
                creditLimit = 150000;
            }
            if(creditScore >= 750 && defaults == 0 && debtRatio < 0.25)
            {
                creditLimit = 300000;
            }
            return creditLimit;
        }
    }
}
