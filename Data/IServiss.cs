using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IServiss
    {
        string ServisDisplayAll();
        bool ServisSaveData(int seventID, string sfirstName, string slastName, string sphonNamber, int sroomNamber, string semail);
    }
}
