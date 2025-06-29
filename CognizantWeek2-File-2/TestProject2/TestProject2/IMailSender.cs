using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2
{
    public interface IMailSender
    {
        bool SendMail(string toAddress, string message);
    }

}
