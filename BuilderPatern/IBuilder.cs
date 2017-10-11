using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Builder
{
    public interface IBuilder<T>
    {
        void makeTitle(string title);
        void makeString(string str);
        void makeItems(String[] items);
        void close();
        T GetResult();
    }
}
