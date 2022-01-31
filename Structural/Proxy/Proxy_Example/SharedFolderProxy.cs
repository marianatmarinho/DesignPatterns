using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Example
{
    public class SharedFolderProxy : ISharedFolder
    {
        private ISharedFolder _folder;
        private Employee _employee;

        public SharedFolderProxy(Employee employee)
        {
            _employee = employee;
        }
        public void ReadWriteOperation()
        {
            if(_employee.Profile.ToUpper() == "CEO")
            {
                _folder = new SharedFolder();
                Console.WriteLine("O proxy Pasta Compartilhada invoca a pasta Real: ReadWriteOperation()\n");
                _folder.ReadWriteOperation();
            }
            else
            {
                Console.WriteLine("O proxy Pasta Compartilhada avisa: Você não tem permissão para acessar essa pasta\n");
            }
        }
    }
}
