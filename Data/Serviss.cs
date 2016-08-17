using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Model;


namespace Service
{
    public class Serviss : IServiss
    {

        private IRepository repo;
        public Serviss(IRepository r)
        {
            this.repo = r;
        }
        public string ServisDisplayAll()
        {
            return repo.DisplayAll();
        }

        public bool ServisSaveData(int seventID, string sfirstName, string slastName, string sphonNamber, int sroomNamber, string semail)
        {
            repo.SaveData(seventID, sfirstName, slastName, sphonNamber, sroomNamber, semail);
            return true;
        }
    }
}


