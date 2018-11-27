using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridGui.Library.Communication.SSH
{
    public class SSHClient
    {
        private SshClient sshClient = null;

        public void Connect(string ipAddress, string username, string password)
        {
            sshClient = new SshClient(ipAddress, 22, username, password);
            sshClient.Connect();
        }
    }
}
